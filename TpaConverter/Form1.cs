using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TpaConverter
{
    public partial class Form1 : Form
    {
        TpaCad tpaCad = new TpaCad();

        public Form1() => InitializeComponent();

        private void Btn_FileTypeEdit_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (File.Exists(Txt_FileTypeEdit.Text))
                    openFileDialog.InitialDirectory = Path.GetFullPath(Txt_FileTypeEdit.Text);
                else
                    openFileDialog.InitialDirectory = Environment.CurrentDirectory;

                openFileDialog.Filter = "cnc files (*.cnc)|*.cnc";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    Txt_FileTypeEdit.Text = openFileDialog.FileName;
            }
        }

        private void Btn_FileTpaCad_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (File.Exists(Txt_FileTpaCad.Text))
                    saveFileDialog.InitialDirectory = Path.GetFullPath(Txt_FileTpaCad.Text);
                else
                    saveFileDialog.InitialDirectory = Environment.CurrentDirectory;

                saveFileDialog.Filter = "tcn files (*.tcn)|*.tcn";
                saveFileDialog.FileName = "File";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    Txt_FileTpaCad.Text = saveFileDialog.FileName;
            }
        }

        string[] TpaCodeArr;
        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                Item item = new Item
                {
                    TpaCode = File.ReadAllLines(Txt_FileTypeEdit.Text),
                    Length = Txt_Length.Text,
                    Width = Txt_Width.Text,
                    Height = Txt_Height.Text
                };

                TpaCodeArr = tpaCad.Start(item);

                File.WriteAllLines(Txt_FileTpaCad.Text, TpaCodeArr);

                MessageBox.Show("Файл успешно конвертирован!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Check_ToolParam_CheckedChanged(object sender, EventArgs e) => Parameters.OnToolParameters = Check_ToolParam.Checked;

        private void Check_MultiStep_CheckedChanged(object sender, EventArgs e) => Parameters.OnStepMode = Check_StepMode.Checked;

        private void Check_Cooling_CheckedChanged(object sender, EventArgs e) => Parameters.OnCooling = Check_Cooling.Checked;
    }
}
