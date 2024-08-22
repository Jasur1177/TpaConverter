namespace TpaConverter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Txt_FileTypeEdit = new System.Windows.Forms.TextBox();
            this.Txt_FileTpaCad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_FileTypeEdit = new System.Windows.Forms.Button();
            this.Btn_FileTpaCad = new System.Windows.Forms.Button();
            this.Txt_Length = new System.Windows.Forms.TextBox();
            this.Txt_Width = new System.Windows.Forms.TextBox();
            this.Txt_Height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Check_ToolParam = new System.Windows.Forms.CheckBox();
            this.Check_StepMode = new System.Windows.Forms.CheckBox();
            this.Check_Cooling = new System.Windows.Forms.CheckBox();
            this.Btn_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_FileTypeEdit
            // 
            this.Txt_FileTypeEdit.Location = new System.Drawing.Point(119, 12);
            this.Txt_FileTypeEdit.Name = "Txt_FileTypeEdit";
            this.Txt_FileTypeEdit.Size = new System.Drawing.Size(450, 20);
            this.Txt_FileTypeEdit.TabIndex = 0;
            // 
            // Txt_FileTpaCad
            // 
            this.Txt_FileTpaCad.Location = new System.Drawing.Point(119, 38);
            this.Txt_FileTpaCad.Name = "Txt_FileTpaCad";
            this.Txt_FileTpaCad.Size = new System.Drawing.Size(450, 20);
            this.Txt_FileTpaCad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Файл из TypeEdit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файл для TpaCad:";
            // 
            // Btn_FileTypeEdit
            // 
            this.Btn_FileTypeEdit.Location = new System.Drawing.Point(570, 11);
            this.Btn_FileTypeEdit.Name = "Btn_FileTypeEdit";
            this.Btn_FileTypeEdit.Size = new System.Drawing.Size(24, 22);
            this.Btn_FileTypeEdit.TabIndex = 1;
            this.Btn_FileTypeEdit.Text = "...";
            this.Btn_FileTypeEdit.UseVisualStyleBackColor = true;
            this.Btn_FileTypeEdit.Click += new System.EventHandler(this.Btn_FileTypeEdit_Click);
            // 
            // Btn_FileTpaCad
            // 
            this.Btn_FileTpaCad.Location = new System.Drawing.Point(570, 37);
            this.Btn_FileTpaCad.Name = "Btn_FileTpaCad";
            this.Btn_FileTpaCad.Size = new System.Drawing.Size(24, 22);
            this.Btn_FileTpaCad.TabIndex = 3;
            this.Btn_FileTpaCad.Text = "...";
            this.Btn_FileTpaCad.UseVisualStyleBackColor = true;
            this.Btn_FileTpaCad.Click += new System.EventHandler(this.Btn_FileTpaCad_Click);
            // 
            // Txt_Length
            // 
            this.Txt_Length.Location = new System.Drawing.Point(119, 64);
            this.Txt_Length.Name = "Txt_Length";
            this.Txt_Length.Size = new System.Drawing.Size(100, 20);
            this.Txt_Length.TabIndex = 4;
            // 
            // Txt_Width
            // 
            this.Txt_Width.Location = new System.Drawing.Point(119, 90);
            this.Txt_Width.Name = "Txt_Width";
            this.Txt_Width.Size = new System.Drawing.Size(100, 20);
            this.Txt_Width.TabIndex = 5;
            // 
            // Txt_Height
            // 
            this.Txt_Height.Location = new System.Drawing.Point(119, 116);
            this.Txt_Height.Name = "Txt_Height";
            this.Txt_Height.Size = new System.Drawing.Size(100, 20);
            this.Txt_Height.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Длина:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ширина:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Высота:";
            // 
            // Check_ToolParam
            // 
            this.Check_ToolParam.AutoSize = true;
            this.Check_ToolParam.Location = new System.Drawing.Point(238, 69);
            this.Check_ToolParam.Name = "Check_ToolParam";
            this.Check_ToolParam.Size = new System.Drawing.Size(153, 17);
            this.Check_ToolParam.TabIndex = 7;
            this.Check_ToolParam.Text = "Параметры инструмента";
            this.Check_ToolParam.UseVisualStyleBackColor = true;
            this.Check_ToolParam.CheckedChanged += new System.EventHandler(this.Check_ToolParam_CheckedChanged);
            // 
            // Check_StepMode
            // 
            this.Check_StepMode.AutoSize = true;
            this.Check_StepMode.Location = new System.Drawing.Point(238, 92);
            this.Check_StepMode.Name = "Check_StepMode";
            this.Check_StepMode.Size = new System.Drawing.Size(125, 17);
            this.Check_StepMode.TabIndex = 8;
            this.Check_StepMode.Text = "Заход без подъема";
            this.Check_StepMode.UseVisualStyleBackColor = true;
            this.Check_StepMode.CheckedChanged += new System.EventHandler(this.Check_MultiStep_CheckedChanged);
            // 
            // Check_Cooling
            // 
            this.Check_Cooling.AutoSize = true;
            this.Check_Cooling.Location = new System.Drawing.Point(238, 115);
            this.Check_Cooling.Name = "Check_Cooling";
            this.Check_Cooling.Size = new System.Drawing.Size(89, 17);
            this.Check_Cooling.TabIndex = 9;
            this.Check_Cooling.Text = "Охлаждение";
            this.Check_Cooling.UseVisualStyleBackColor = true;
            this.Check_Cooling.CheckedChanged += new System.EventHandler(this.Check_Cooling_CheckedChanged);
            // 
            // Btn_Convert
            // 
            this.Btn_Convert.Location = new System.Drawing.Point(445, 93);
            this.Btn_Convert.Name = "Btn_Convert";
            this.Btn_Convert.Size = new System.Drawing.Size(148, 42);
            this.Btn_Convert.TabIndex = 10;
            this.Btn_Convert.Text = "Конвертировать";
            this.Btn_Convert.UseVisualStyleBackColor = true;
            this.Btn_Convert.Click += new System.EventHandler(this.Btn_Convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 151);
            this.Controls.Add(this.Btn_Convert);
            this.Controls.Add(this.Check_Cooling);
            this.Controls.Add(this.Check_StepMode);
            this.Controls.Add(this.Check_ToolParam);
            this.Controls.Add(this.Btn_FileTpaCad);
            this.Controls.Add(this.Btn_FileTypeEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Height);
            this.Controls.Add(this.Txt_Width);
            this.Controls.Add(this.Txt_Length);
            this.Controls.Add(this.Txt_FileTpaCad);
            this.Controls.Add(this.Txt_FileTypeEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(624, 190);
            this.MinimumSize = new System.Drawing.Size(624, 190);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter TypeEdit 2005 to TpaCad 2.0 for profit H80";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_FileTypeEdit;
        private System.Windows.Forms.TextBox Txt_FileTpaCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_FileTypeEdit;
        private System.Windows.Forms.Button Btn_FileTpaCad;
        private System.Windows.Forms.TextBox Txt_Length;
        private System.Windows.Forms.TextBox Txt_Width;
        private System.Windows.Forms.TextBox Txt_Height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Check_ToolParam;
        private System.Windows.Forms.CheckBox Check_StepMode;
        private System.Windows.Forms.CheckBox Check_Cooling;
        private System.Windows.Forms.Button Btn_Convert;
    }
}

