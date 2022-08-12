namespace ExcelToPPNED
{
    partial class FormMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bOpenExcel = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.tbNameList = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbUNN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCvartal = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nIdPasp = new System.Windows.Forms.NumericUpDown();
            this.nDateEnd = new System.Windows.Forms.NumericUpDown();
            this.ndateStart = new System.Windows.Forms.NumericUpDown();
            this.nfathername = new System.Windows.Forms.NumericUpDown();
            this.nName = new System.Windows.Forms.NumericUpDown();
            this.nFam = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIdPasp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndateStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nfathername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 276);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bOpenExcel);
            this.tabPage1.Controls.Add(this.tbFile);
            this.tabPage1.Controls.Add(this.tbNameList);
            this.tabPage1.Controls.Add(this.tbYear);
            this.tabPage1.Controls.Add(this.tbUNN);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cBoxCvartal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bOpenExcel
            // 
            this.bOpenExcel.Location = new System.Drawing.Point(290, 109);
            this.bOpenExcel.Name = "bOpenExcel";
            this.bOpenExcel.Size = new System.Drawing.Size(24, 20);
            this.bOpenExcel.TabIndex = 10;
            this.bOpenExcel.Text = "...";
            this.bOpenExcel.UseVisualStyleBackColor = true;
            this.bOpenExcel.Click += new System.EventHandler(this.bOpenExcel_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(158, 109);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(126, 20);
            this.tbFile.TabIndex = 9;
            // 
            // tbNameList
            // 
            this.tbNameList.Location = new System.Drawing.Point(158, 83);
            this.tbNameList.Name = "tbNameList";
            this.tbNameList.Size = new System.Drawing.Size(156, 20);
            this.tbNameList.TabIndex = 8;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(158, 32);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(156, 20);
            this.tbYear.TabIndex = 7;
            this.tbYear.Text = "2022";
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYear_KeyPress);
            // 
            // tbUNN
            // 
            this.tbUNN.Location = new System.Drawing.Point(158, 4);
            this.tbUNN.Name = "tbUNN";
            this.tbUNN.Size = new System.Drawing.Size(156, 20);
            this.tbUNN.TabIndex = 6;
            this.tbUNN.Text = "200166687";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Путь к Excel файлу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Наименование списка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Картал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Год";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "УНН";
            // 
            // cBoxCvartal
            // 
            this.cBoxCvartal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCvartal.FormattingEnabled = true;
            this.cBoxCvartal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cBoxCvartal.Location = new System.Drawing.Point(158, 56);
            this.cBoxCvartal.Name = "cBoxCvartal";
            this.cBoxCvartal.Size = new System.Drawing.Size(156, 21);
            this.cBoxCvartal.Sorted = true;
            this.cBoxCvartal.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nIdPasp);
            this.tabPage2.Controls.Add(this.nDateEnd);
            this.tabPage2.Controls.Add(this.ndateStart);
            this.tabPage2.Controls.Add(this.nfathername);
            this.tabPage2.Controls.Add(this.nName);
            this.tabPage2.Controls.Add(this.nFam);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройка Excel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nIdPasp
            // 
            this.nIdPasp.Location = new System.Drawing.Point(149, 139);
            this.nIdPasp.Name = "nIdPasp";
            this.nIdPasp.Size = new System.Drawing.Size(120, 20);
            this.nIdPasp.TabIndex = 16;
            this.nIdPasp.Value = new decimal(new int[] {
            37,
            0,
            0,
            0});
            // 
            // nDateEnd
            // 
            this.nDateEnd.Location = new System.Drawing.Point(149, 112);
            this.nDateEnd.Name = "nDateEnd";
            this.nDateEnd.Size = new System.Drawing.Size(120, 20);
            this.nDateEnd.TabIndex = 15;
            this.nDateEnd.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // ndateStart
            // 
            this.ndateStart.Location = new System.Drawing.Point(149, 85);
            this.ndateStart.Name = "ndateStart";
            this.ndateStart.Size = new System.Drawing.Size(120, 20);
            this.ndateStart.TabIndex = 14;
            this.ndateStart.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nfathername
            // 
            this.nfathername.Location = new System.Drawing.Point(149, 58);
            this.nfathername.Name = "nfathername";
            this.nfathername.Size = new System.Drawing.Size(120, 20);
            this.nfathername.TabIndex = 13;
            this.nfathername.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nName
            // 
            this.nName.Location = new System.Drawing.Point(149, 32);
            this.nName.Name = "nName";
            this.nName.Size = new System.Drawing.Size(120, 20);
            this.nName.TabIndex = 12;
            this.nName.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nFam
            // 
            this.nFam.Location = new System.Drawing.Point(149, 9);
            this.nFam.Name = "nFam";
            this.nFam.Size = new System.Drawing.Size(120, 20);
            this.nFam.TabIndex = 11;
            this.nFam.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "ИД Паспорта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Дата завершения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Дата начала";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Фамилия";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 294);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(336, 23);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Начать";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx|All files (*.*)|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 330);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Импорт Excel в PPNED";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIdPasp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndateStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nfathername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.TextBox tbNameList;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbUNN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCvartal;
        private System.Windows.Forms.Button bOpenExcel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nIdPasp;
        private System.Windows.Forms.NumericUpDown nDateEnd;
        private System.Windows.Forms.NumericUpDown ndateStart;
        private System.Windows.Forms.NumericUpDown nfathername;
        private System.Windows.Forms.NumericUpDown nName;
        private System.Windows.Forms.NumericUpDown nFam;
    }
}

