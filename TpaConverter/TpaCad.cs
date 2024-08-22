using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TpaConverter
{
    internal class TpaCad
    {
        private const string MILLING = "W#89{ ::WTs"; // W#89 фрезерование, работает только шпиндель с фрезой (G00)
        private const string DRILLING = "W#81{ ::WTp"; // W#81 сверление отверстий, запускаются шпиндели со сверлами (G00,G01)
        private const string LINE = "W#2101"; // W#2101 прямые или кривые линии (G01)
        private const string FEEDRATE = "#2008="; // #2008=6 скорость подачи, м/м (F6000)
        private const string DOWNSPEED = "2005="; // 2005=1.5 скорость захода, м/м (F1500)
        private const string ROTATIONSPEED = "2002="; // 2002=18000 скорость вращения шпинделя, об/мин (S18000)
        private const string COOLING = "#9510=8 "; // #9510=8 воздушное охлаждение (M8)
        private const string TOOL = "#205="; /*
                                              * #205=2404 номер инструмента (T2404)
                                              * сверло получает номер ячеейки c 1 до 12
                                              * фрезы получают из TpaCad НЕ номер ячеейки а ID инструмента, ID начинается с 2000
                                              * номер ячеейки для фрезы задается на самом станке
                                              * если номер инструмента больше 12 это фреза
                                             */

        private string[] TpaCode;
        private int Count = 0;

        public string[] Start(Item item)
        {
            if (item == null) return null;

            TpaCode = item.TpaCode;
            Count = 1;

            for (int i = 0; i < TpaCode.Length; i++)
            {
                // Последовательность операций
                if (TpaCode[i].StartsWith("W#89"))
                {
                    TpaCode[i] = TpaCode[i].Insert(12, "WS=" + Count);
                    Count++;
                }

                // Получаем параметры инструмента из TypeEdit.
                if (Parameters.OnToolParameters == true)
                {
                    if (TpaCode[i].Contains(FEEDRATE))
                        TpaCode[i] = OnSpeed(TpaCode[i], FEEDRATE);

                    if (TpaCode[i].Contains(DOWNSPEED))
                        TpaCode[i] = OnSpeed(TpaCode[i], DOWNSPEED);
                }
                else
                {
                    if (TpaCode[i].Contains(FEEDRATE))
                        TpaCode[i] = OffSpeed(TpaCode[i], FEEDRATE);

                    if (TpaCode[i].Contains(DOWNSPEED))
                        TpaCode[i] = OffSpeed(TpaCode[i], DOWNSPEED);

                    if (TpaCode[i].Contains(ROTATIONSPEED))
                        TpaCode[i] = OffSpeed(TpaCode[i], ROTATIONSPEED);
                }

                // Проверка фрезерования или сверления
                if (TpaCode[i].Contains(TOOL))
                {
                    if (ToolId(TpaCode[i], TOOL) <= 12)
                        TpaCode[i] = TpaCode[i].Replace(MILLING, DRILLING);
                }

                // Включить охлаждение инструмента, только для фрезы
                if (Parameters.OnCooling == true)
                {
                    if (TpaCode[i].StartsWith(MILLING))
                        TpaCode[i] = TpaCode[i].Insert(TpaCode[i].IndexOf("}W"), COOLING);
                }
            }

            if (Parameters.OnStepMode == true)
                TpaCode = new StepMode().OnStepMode(TpaCode);

            return HeadArr(item.Length, item.Width, item.Height).Concat(TpaCode).ToArray();
        }

        string speed = null;
        MatchCollection matches = null;

        #region Скорость подачи

        /*
         * в TypeEdit скорость подачи определяется в мм/м
         * TpaCad работает в м/м
         * переводим мм/м в м/м
         */
        private string OnSpeed(string input, string key)
        {
            matches = Regex.Matches(input, key + @"(\d+)");
            speed = (Convert.ToInt32(matches[0].Groups[1].Value) / 1000d).ToString();
            return input.Replace(matches[0].Value, key + speed);
        }

        private string OffSpeed(string input, string key)
        {
            matches = Regex.Matches(input, key + @"(\d+)");
            speed = (Convert.ToInt32(matches[0].Groups[1].Value) / 1000d).ToString();
            return input.Replace(matches[0].Value + " ", "");
        }

        // определяем номер инструмента
        private int ToolId(string input, string key)
        {
            matches = Regex.Matches(input, key + @"(\d+)");
            return (Convert.ToInt32(matches[0].Groups[1].Value));
        }

        #endregion

        string[] headTpaCode = new string[16];
        private string[] HeadArr(string length, string width, string hieght)
        {
            headTpaCode[0] = @"TPA\ALBATROS\EDICAD\02.00:1551:r0w0h0s2";
            headTpaCode[1] = "::SIDE=1;";
            headTpaCode[2] = "::UNm DL=" + length + " DH=" + width + " DS=" + hieght;
            headTpaCode[3] = "'tcn version=2.6.14";
            headTpaCode[4] = "'code=unicode";
            headTpaCode[5] = "EXE{\n#0=0\n#1=0\n#2=0\n#3=0\n#4=0\n}EXE";
            headTpaCode[6] = "OFFS{\n#0=0|0\n#1=0|0\n#2=0|0\n}OFFS";
            headTpaCode[7] = "VARV{\n#0=1|1\n#1=2|2\n#2=3|3\n#3=4|4\n#4=0|0\n#5=0|0\n#6=0|0\n#7=0|\n}VARV";
            headTpaCode[8] = "VAR{\n}VAR";
            headTpaCode[9] = "SPEC{\n}SPEC";
            headTpaCode[10] = "INFO{\n}INFO";
            headTpaCode[11] = "OPTI{";
            headTpaCode[12] = ":: OPTDEF=1 OPTIMIZE=%;0 OPTMIN=0 OPT3=0 OPT0=0 OPTTOOL=0 OPT2=0 OPTX=0 OPTY=0 OPTR=0 OPT4=0 OPT6=0 OPT7=0 LSTCOD=0%1%2%3 LTOOLFR=0 LTOOLPN=0 OPTF1=0 OOO=0.5";
            headTpaCode[13] = "}OPTI";
            headTpaCode[14] = "LINK{\n}LINK";
            headTpaCode[15] = "SIDE#0{\n}SIDE";

            return headTpaCode;
        }
    }
}
