using System;
using System.Text.RegularExpressions;

namespace TpaConverter
{
    internal class StepMode
    {
        MatchCollection matches = null;

        double X1 = 0;
        double Y1 = 0;
        double X2 = 0;
        double Y2 = 0;

        double x = 0;
        double y = 0;

        string setup = "";
        string z = null;

        int count = 0;

        public string[] OnStepMode(string[] arr)
        {
            count = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].StartsWith("W#89"))
                {
                    if (setup == Regex.Replace(arr[i], @"#3=(\S+)", ""))
                    {
                        X1 = GetXY(arr[i - 1]).Item1;
                        Y1 = GetXY(arr[i - 1]).Item2;
                        X2 = GetXY(arr[i]).Item1;
                        Y2 = GetXY(arr[i]).Item2;

                        z = Z(arr[i], "#3=");

                        if (X1 == X2 && Y1 == Y2)
                            arr[i] = "W#2201{ ::WTl  #8015=0 #3=" + z + " }W";
                    }
                    else
                    {
                        setup = Regex.Replace(arr[i], @"#3=(\S+)", "");
                    }
                }

                if (arr[i].StartsWith("W#89") || arr[i].StartsWith("W#81"))
                {
                    arr[i] = arr[i].Insert(12, "WS=" + count);
                    count++;
                }
            }

            setup = "";

            return arr;
        }


        public Tuple<double, double> GetXY(string input)
        {
            matches = Regex.Matches(input, @"#1=(\S+)");
            x = Convert.ToDouble(matches[0].Groups[1].Value);

            matches = Regex.Matches(input, @"#2=(\S+)");
            y = Convert.ToDouble(matches[0].Groups[1].Value);

            return Tuple.Create(x, y);
        }

        public string Z(string input, string key)
        {
            matches = Regex.Matches(input, key + @"(\S+)");
            return matches[0].Groups[1].Value;
        }
    }
}
