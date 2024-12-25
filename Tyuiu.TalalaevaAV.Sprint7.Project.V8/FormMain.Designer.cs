namespace Tyuiu.TalalaevaAV.Sprint7.Project.V8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelOther_TAV = new Panel();
            dataGridViewDrivers_TAV = new DataGridView();
            openFileDialog_TAV = new OpenFileDialog();
            panelData_TAV = new Panel();
            buttonAbout_TAV = new Button();
            buttonAddDriver_TAV = new Button();
            buttonEditDriver_TAV = new Button();
            buttonDeleteDriver_TAV = new Button();
            buttonSearchDriver_TAV = new Button();
            buttonSortDriver_TAV = new Button();
            buttonSaveDriver_TAV = new Button();
            buttonLoadDriver_TAV = new Button();
            panelButtons_TAV = new Panel();
            groupBox4 = new GroupBox();
            textBoxStatistics_TAV = new TextBox();
            buttonStatistics_TAV = new Button();
            groupBox3 = new GroupBox();
            labelSearch_TAV = new Label();
            textBoxSearch_TAV = new TextBox();
            groupBox2 = new GroupBox();
            textBoxMaxExperience_TAV = new TextBox();
            textBoxMinExperience_TAV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonFilterDriver_TAV = new Button();
            groupBox1 = new GroupBox();
            saveFileDialog_TAV = new SaveFileDialog();
            toolTip_TAV = new ToolTip(components);
            panelOther_TAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers_TAV).BeginInit();
            panelData_TAV.SuspendLayout();
            panelButtons_TAV.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelOther_TAV
            // 
            panelOther_TAV.Controls.Add(dataGridViewDrivers_TAV);
            panelOther_TAV.Dock = DockStyle.Fill;
            panelOther_TAV.Location = new Point(0, 180);
            panelOther_TAV.Name = "panelOther_TAV";
            panelOther_TAV.Size = new Size(1059, 353);
            panelOther_TAV.TabIndex = 1;
            // 
            // dataGridViewDrivers_TAV
            // 
            dataGridViewDrivers_TAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers_TAV.Dock = DockStyle.Fill;
            dataGridViewDrivers_TAV.Location = new Point(0, 0);
            dataGridViewDrivers_TAV.Name = "dataGridViewDrivers_TAV";
            dataGridViewDrivers_TAV.ReadOnly = true;
            dataGridViewDrivers_TAV.Size = new Size(1059, 353);
            dataGridViewDrivers_TAV.TabIndex = 0;
            // 
            // openFileDialog_TAV
            // 
            openFileDialog_TAV.FileName = "openFileDialog1";
            // 
            // panelData_TAV
            // 
            panelData_TAV.Controls.Add(buttonAbout_TAV);
            panelData_TAV.Dock = DockStyle.Right;
            panelData_TAV.Location = new Point(962, 0);
            panelData_TAV.Name = "panelData_TAV";
            panelData_TAV.Size = new Size(97, 180);
            panelData_TAV.TabIndex = 0;
            // 
            // buttonAbout_TAV
            // 
            buttonAbout_TAV.Image = (Image)resources.GetObject("buttonAbout_TAV.Image");
            buttonAbout_TAV.Location = new Point(16, 21);
            buttonAbout_TAV.Name = "buttonAbout_TAV";
            buttonAbout_TAV.Size = new Size(55, 42);
            buttonAbout_TAV.TabIndex = 0;
            toolTip_TAV.SetToolTip(buttonAbout_TAV, "Информаиця о разработчике");
            buttonAbout_TAV.UseVisualStyleBackColor = true;
            buttonAbout_TAV.Click += buttonAbout_TAV_Click;
            // 
            // buttonAddDriver_TAV
            // 
            buttonAddDriver_TAV.Location = new Point(6, 17);
            buttonAddDriver_TAV.Name = "buttonAddDriver_TAV";
            buttonAddDriver_TAV.Size = new Size(80, 37);
            buttonAddDriver_TAV.TabIndex = 1;
            buttonAddDriver_TAV.Text = "Добавить";
            toolTip_TAV.SetToolTip(buttonAddDriver_TAV, "Добавить данные о водителе");
            buttonAddDriver_TAV.UseVisualStyleBackColor = true;
            buttonAddDriver_TAV.Click += buttonAddDriver_TAV_Click;
            // 
            // buttonEditDriver_TAV
            // 
            buttonEditDriver_TAV.Location = new Point(92, 17);
            buttonEditDriver_TAV.Name = "buttonEditDriver_TAV";
            buttonEditDriver_TAV.Size = new Size(71, 35);
            buttonEditDriver_TAV.TabIndex = 2;
            buttonEditDriver_TAV.Text = "Изменить";
            toolTip_TAV.SetToolTip(buttonEditDriver_TAV, "Изменить данные о водителе");
            buttonEditDriver_TAV.UseVisualStyleBackColor = true;
            buttonEditDriver_TAV.Click += buttonEditDriver_TAV_Click;
            // 
            // buttonDeleteDriver_TAV
            // 
            buttonDeleteDriver_TAV.Location = new Point(169, 18);
            buttonDeleteDriver_TAV.Name = "buttonDeleteDriver_TAV";
            buttonDeleteDriver_TAV.Size = new Size(62, 34);
            buttonDeleteDriver_TAV.TabIndex = 3;
            buttonDeleteDriver_TAV.Text = "Удалить";
            toolTip_TAV.SetToolTip(buttonDeleteDriver_TAV, "Удалить данные о водителе");
            buttonDeleteDriver_TAV.UseVisualStyleBackColor = true;
            buttonDeleteDriver_TAV.Click += buttonDeleteDriver_TAV_Click;
            // 
            // buttonSearchDriver_TAV
            // 
            buttonSearchDriver_TAV.Location = new Point(54, 63);
            buttonSearchDriver_TAV.Name = "buttonSearchDriver_TAV";
            buttonSearchDriver_TAV.Size = new Size(57, 22);
            buttonSearchDriver_TAV.TabIndex = 4;
            buttonSearchDriver_TAV.Text = "Найти";
            toolTip_TAV.SetToolTip(buttonSearchDriver_TAV, "Поиск по фамилии, имени или отчеству");
            buttonSearchDriver_TAV.UseVisualStyleBackColor = true;
            buttonSearchDriver_TAV.Click += buttonSearchDriver_TAV_Click;
            // 
            // buttonSortDriver_TAV
            // 
            buttonSortDriver_TAV.Location = new Point(237, 18);
            buttonSortDriver_TAV.Name = "buttonSortDriver_TAV";
            buttonSortDriver_TAV.Size = new Size(91, 34);
            buttonSortDriver_TAV.TabIndex = 5;
            buttonSortDriver_TAV.Text = "Сортировать ";
            toolTip_TAV.SetToolTip(buttonSortDriver_TAV, "Выполняется сортировка по окладу");
            buttonSortDriver_TAV.UseVisualStyleBackColor = true;
            buttonSortDriver_TAV.Click += buttonSortDriver_TAV_Click;
            // 
            // buttonSaveDriver_TAV
            // 
            buttonSaveDriver_TAV.Image = (Image)resources.GetObject("buttonSaveDriver_TAV.Image");
            buttonSaveDriver_TAV.Location = new Point(15, 79);
            buttonSaveDriver_TAV.Name = "buttonSaveDriver_TAV";
            buttonSaveDriver_TAV.Size = new Size(44, 46);
            buttonSaveDriver_TAV.TabIndex = 6;
            toolTip_TAV.SetToolTip(buttonSaveDriver_TAV, "Сохранить изменения в файле, как в новом");
            buttonSaveDriver_TAV.UseVisualStyleBackColor = true;
            buttonSaveDriver_TAV.Click += buttonSaveDriver_TAV_Click;
            // 
            // buttonLoadDriver_TAV
            // 
            buttonLoadDriver_TAV.Image = (Image)resources.GetObject("buttonLoadDriver_TAV.Image");
            buttonLoadDriver_TAV.Location = new Point(65, 79);
            buttonLoadDriver_TAV.Name = "buttonLoadDriver_TAV";
            buttonLoadDriver_TAV.Size = new Size(42, 46);
            buttonLoadDriver_TAV.TabIndex = 7;
            toolTip_TAV.SetToolTip(buttonLoadDriver_TAV, "Открыть другой файл");
            buttonLoadDriver_TAV.UseVisualStyleBackColor = true;
            buttonLoadDriver_TAV.Click += buttonLoadDriver_TAV_Click;
            // 
            // panelButtons_TAV
            // 
            panelButtons_TAV.Controls.Add(groupBox4);
            panelButtons_TAV.Controls.Add(buttonStatistics_TAV);
            panelButtons_TAV.Controls.Add(groupBox3);
            panelButtons_TAV.Controls.Add(groupBox2);
            panelButtons_TAV.Controls.Add(groupBox1);
            panelButtons_TAV.Controls.Add(buttonLoadDriver_TAV);
            panelButtons_TAV.Controls.Add(buttonSaveDriver_TAV);
            panelButtons_TAV.Controls.Add(panelData_TAV);
            panelButtons_TAV.Dock = DockStyle.Top;
            panelButtons_TAV.Location = new Point(0, 0);
            panelButtons_TAV.Name = "panelButtons_TAV";
            panelButtons_TAV.Size = new Size(1059, 180);
            panelButtons_TAV.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxStatistics_TAV);
            groupBox4.Location = new Point(643, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(297, 119);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Статистика";
            // 
            // textBoxStatistics_TAV
            // 
            textBoxStatistics_TAV.BackColor = SystemColors.Menu;
            textBoxStatistics_TAV.BorderStyle = BorderStyle.None;
            textBoxStatistics_TAV.Dock = DockStyle.Fill;
            textBoxStatistics_TAV.Location = new Point(3, 19);
            textBoxStatistics_TAV.Multiline = true;
            textBoxStatistics_TAV.Name = "textBoxStatistics_TAV";
            textBoxStatistics_TAV.ReadOnly = true;
            textBoxStatistics_TAV.Size = new Size(291, 97);
            textBoxStatistics_TAV.TabIndex = 15;
            // 
            // buttonStatistics_TAV
            // 
            buttonStatistics_TAV.Location = new Point(646, 138);
            buttonStatistics_TAV.Name = "buttonStatistics_TAV";
            buttonStatistics_TAV.Size = new Size(294, 27);
            buttonStatistics_TAV.TabIndex = 14;
            buttonStatistics_TAV.Text = "Отобразить";
            toolTip_TAV.SetToolTip(buttonStatistics_TAV, "Статистика на осноьве данных таблицы");
            buttonStatistics_TAV.UseVisualStyleBackColor = true;
            buttonStatistics_TAV.Click += buttonStatistics_TAV_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelSearch_TAV);
            groupBox3.Controls.Add(textBoxSearch_TAV);
            groupBox3.Controls.Add(buttonSearchDriver_TAV);
            groupBox3.Location = new Point(511, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(126, 109);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // labelSearch_TAV
            // 
            labelSearch_TAV.AutoSize = true;
            labelSearch_TAV.Location = new Point(6, 29);
            labelSearch_TAV.Name = "labelSearch_TAV";
            labelSearch_TAV.Size = new Size(42, 15);
            labelSearch_TAV.TabIndex = 9;
            labelSearch_TAV.Text = "Поиск";
            labelSearch_TAV.Click += labelSearch_TAV_Click;
            // 
            // textBoxSearch_TAV
            // 
            textBoxSearch_TAV.Location = new Point(54, 26);
            textBoxSearch_TAV.Name = "textBoxSearch_TAV";
            textBoxSearch_TAV.Size = new Size(57, 23);
            textBoxSearch_TAV.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxMaxExperience_TAV);
            groupBox2.Controls.Add(textBoxMinExperience_TAV);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(buttonFilterDriver_TAV);
            groupBox2.Location = new Point(356, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(149, 109);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Фильтрация ";
            // 
            // textBoxMaxExperience_TAV
            // 
            textBoxMaxExperience_TAV.Location = new Point(79, 53);
            textBoxMaxExperience_TAV.Name = "textBoxMaxExperience_TAV";
            textBoxMaxExperience_TAV.Size = new Size(53, 23);
            textBoxMaxExperience_TAV.TabIndex = 15;
            // 
            // textBoxMinExperience_TAV
            // 
            textBoxMinExperience_TAV.Location = new Point(79, 23);
            textBoxMinExperience_TAV.Name = "textBoxMinExperience_TAV";
            textBoxMinExperience_TAV.Size = new Size(53, 23);
            textBoxMinExperience_TAV.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 52);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 13;
            label2.Text = "Макс.стаж";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 26);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 12;
            label1.Text = "Мин.стаж";
            // 
            // buttonFilterDriver_TAV
            // 
            buttonFilterDriver_TAV.Location = new Point(55, 79);
            buttonFilterDriver_TAV.Name = "buttonFilterDriver_TAV";
            buttonFilterDriver_TAV.Size = new Size(77, 24);
            buttonFilterDriver_TAV.TabIndex = 11;
            buttonFilterDriver_TAV.Text = "Выполнить";
            toolTip_TAV.SetToolTip(buttonFilterDriver_TAV, "Выполняется фильтрация по стажу");
            buttonFilterDriver_TAV.UseVisualStyleBackColor = true;
            buttonFilterDriver_TAV.Click += buttonFilterDriver_TAV_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddDriver_TAV);
            groupBox1.Controls.Add(buttonEditDriver_TAV);
            groupBox1.Controls.Add(buttonDeleteDriver_TAV);
            groupBox1.Controls.Add(buttonSortDriver_TAV);
            groupBox1.Location = new Point(9, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 62);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Работа с файлом";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 533);
            Controls.Add(panelOther_TAV);
            Controls.Add(panelButtons_TAV);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Вариант 8 | Талалаева А.В.";
            Load += FormMain_Load;
            panelOther_TAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers_TAV).EndInit();
            panelData_TAV.ResumeLayout(false);
            panelButtons_TAV.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelOther_TAV;
        private OpenFileDialog openFileDialog_TAV;
        private Panel panelData_TAV;
        private Button buttonAbout_TAV;
        private Button buttonAddDriver_TAV;
        private Button buttonEditDriver_TAV;
        private Button buttonDeleteDriver_TAV;
        private Button buttonSearchDriver_TAV;
        private Button buttonSortDriver_TAV;
        private Button buttonSaveDriver_TAV;
        private Button buttonLoadDriver_TAV;
        private Panel panelButtons_TAV;
        private TextBox textBoxSearch_TAV;
        private Label labelSearch_TAV;
        private SaveFileDialog saveFileDialog_TAV;
        private DataGridView dataGridViewDrivers_TAV;
        private GroupBox groupBox1;
        private ToolTip toolTip_TAV;
        private Button buttonFilterDriver_TAV;
        private GroupBox groupBox2;
        private TextBox textBoxMaxExperience_TAV;
        private TextBox textBoxMinExperience_TAV;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button buttonStatistics_TAV;
        private GroupBox groupBox4;
        private TextBox textBoxStatistics_TAV;
    }
}
