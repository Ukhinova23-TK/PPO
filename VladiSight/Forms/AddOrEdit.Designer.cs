namespace VladiSight.Forms
{
    partial class AddOrEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DiscriptionLabel = new System.Windows.Forms.Label();
            this.DiscriptionTextBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CreationDateLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.AbusLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AbusListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BusListBox1 = new System.Windows.Forms.CheckedListBox();
            this.TaxiListBox = new System.Windows.Forms.CheckedListBox();
            this.BusStopLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BusStopTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddPictureButton = new System.Windows.Forms.Button();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(385, 31);
            this.NameTextBox.MaxLength = 255;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(249, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(274, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Название*";
            // 
            // DiscriptionLabel
            // 
            this.DiscriptionLabel.AutoSize = true;
            this.DiscriptionLabel.Location = new System.Drawing.Point(274, 68);
            this.DiscriptionLabel.Name = "DiscriptionLabel";
            this.DiscriptionLabel.Size = new System.Drawing.Size(61, 13);
            this.DiscriptionLabel.TabIndex = 3;
            this.DiscriptionLabel.Text = "Описание*";
            // 
            // DiscriptionTextBox
            // 
            this.DiscriptionTextBox.Location = new System.Drawing.Point(385, 65);
            this.DiscriptionTextBox.MaxLength = 4000;
            this.DiscriptionTextBox.Multiline = true;
            this.DiscriptionTextBox.Name = "DiscriptionTextBox";
            this.DiscriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DiscriptionTextBox.Size = new System.Drawing.Size(249, 87);
            this.DiscriptionTextBox.TabIndex = 2;
            this.DiscriptionTextBox.TextChanged += new System.EventHandler(this.DiscriptionTextBox_TextChanged);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(274, 171);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 5;
            this.AuthorLabel.Text = "Автор*";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(385, 168);
            this.AuthorTextBox.MaxLength = 255;
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(249, 20);
            this.AuthorTextBox.TabIndex = 4;
            this.AuthorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(274, 201);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(107, 13);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "Место нахождения*";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(385, 198);
            this.AddressTextBox.MaxLength = 255;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(249, 20);
            this.AddressTextBox.TabIndex = 6;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // CreationDateLabel
            // 
            this.CreationDateLabel.AutoSize = true;
            this.CreationDateLabel.Location = new System.Drawing.Point(274, 230);
            this.CreationDateLabel.Name = "CreationDateLabel";
            this.CreationDateLabel.Size = new System.Drawing.Size(80, 13);
            this.CreationDateLabel.TabIndex = 9;
            this.CreationDateLabel.Text = "Год создания*";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.PaleGreen;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Location = new System.Drawing.Point(727, 317);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(727, 346);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Отменить";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.Salmon;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelButton.Location = new System.Drawing.Point(727, 288);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 15;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // AbusLable
            // 
            this.AbusLable.AutoSize = true;
            this.AbusLable.Location = new System.Drawing.Point(647, 34);
            this.AbusLable.Name = "AbusLable";
            this.AbusLable.Size = new System.Drawing.Size(59, 13);
            this.AbusLable.TabIndex = 16;
            this.AbusLable.Text = "Автобусы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Троллейбусы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Маршрутные такси:";
            // 
            // AbusListBox1
            // 
            this.AbusListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.AbusListBox1.CheckOnClick = true;
            this.AbusListBox1.FormattingEnabled = true;
            this.AbusListBox1.Items.AddRange(new object[] {
            "1с",
            "2",
            "6с",
            "7с",
            "11",
            "14",
            "15",
            "17",
            "18с",
            "20с",
            "21с",
            "22",
            "23",
            "24с",
            "25",
            "26",
            "27",
            "28",
            "29с",
            "32"});
            this.AbusListBox1.Location = new System.Drawing.Point(650, 65);
            this.AbusListBox1.Name = "AbusListBox1";
            this.AbusListBox1.Size = new System.Drawing.Size(56, 304);
            this.AbusListBox1.TabIndex = 19;
            this.AbusListBox1.Click += new System.EventHandler(this.AbusListBox1_Click);
            // 
            // BusListBox1
            // 
            this.BusListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.BusListBox1.CheckOnClick = true;
            this.BusListBox1.FormattingEnabled = true;
            this.BusListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "7",
            "8",
            "10",
            "11",
            "12"});
            this.BusListBox1.Location = new System.Drawing.Point(738, 65);
            this.BusListBox1.Name = "BusListBox1";
            this.BusListBox1.Size = new System.Drawing.Size(52, 124);
            this.BusListBox1.TabIndex = 20;
            this.BusListBox1.Click += new System.EventHandler(this.BusListBox1_Click);
            // 
            // TaxiListBox
            // 
            this.TaxiListBox.BackColor = System.Drawing.SystemColors.Control;
            this.TaxiListBox.CheckOnClick = true;
            this.TaxiListBox.FormattingEnabled = true;
            this.TaxiListBox.Items.AddRange(new object[] {
            "5",
            "36"});
            this.TaxiListBox.Location = new System.Drawing.Point(738, 230);
            this.TaxiListBox.Name = "TaxiListBox";
            this.TaxiListBox.Size = new System.Drawing.Size(49, 34);
            this.TaxiListBox.TabIndex = 21;
            this.TaxiListBox.Click += new System.EventHandler(this.TaxiListBox_Click);
            // 
            // BusStopLable
            // 
            this.BusStopLable.AutoSize = true;
            this.BusStopLable.Location = new System.Drawing.Point(274, 268);
            this.BusStopLable.Name = "BusStopLable";
            this.BusStopLable.Size = new System.Drawing.Size(66, 13);
            this.BusStopLable.TabIndex = 22;
            this.BusStopLable.Text = "Остановка*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Статус*";
            // 
            // BusStopTextBox
            // 
            this.BusStopTextBox.Location = new System.Drawing.Point(385, 265);
            this.BusStopTextBox.MaxLength = 255;
            this.BusStopTextBox.Name = "BusStopTextBox";
            this.BusStopTextBox.Size = new System.Drawing.Size(249, 20);
            this.BusStopTextBox.TabIndex = 24;
            this.BusStopTextBox.TextChanged += new System.EventHandler(this.BusStopTextBox_TextChanged);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "World Monuments Fund",
            "Список Всемирного Наследия ЮНЕСКО",
            "Под защитой государства",
            "Отсутствует"});
            this.StatusComboBox.Location = new System.Drawing.Point(385, 301);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(249, 21);
            this.StatusComboBox.TabIndex = 25;
            this.StatusComboBox.TextChanged += new System.EventHandler(this.StatusComboBox_TextChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Location = new System.Drawing.Point(12, 28);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(232, 209);
            this.PictureBox.TabIndex = 26;
            this.PictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.BackColor = System.Drawing.Color.Khaki;
            this.AddPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPictureButton.Location = new System.Drawing.Point(55, 243);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(150, 21);
            this.AddPictureButton.TabIndex = 27;
            this.AddPictureButton.Text = "Добавить изображение";
            this.AddPictureButton.UseVisualStyleBackColor = false;
            this.AddPictureButton.Click += new System.EventHandler(this.AddPictureButton_Click);
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YearNumericUpDown.Location = new System.Drawing.Point(385, 230);
            this.YearNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.YearNumericUpDown.TabIndex = 28;
            this.YearNumericUpDown.ValueChanged += new System.EventHandler(this.YearNumericUpDown_ValueChanged);
            // 
            // AddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(835, 377);
            this.Controls.Add(this.YearNumericUpDown);
            this.Controls.Add(this.AddPictureButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.BusStopTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BusStopLable);
            this.Controls.Add(this.TaxiListBox);
            this.Controls.Add(this.BusListBox1);
            this.Controls.Add(this.AbusListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AbusLable);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CreationDateLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.DiscriptionLabel);
            this.Controls.Add(this.DiscriptionTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.MinimumSize = new System.Drawing.Size(283, 256);
            this.Name = "AddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать или Изменить";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DiscriptionLabel;
        private System.Windows.Forms.TextBox DiscriptionTextBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label CreationDateLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label AbusLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox AbusListBox1;
        private System.Windows.Forms.CheckedListBox BusListBox1;
        private System.Windows.Forms.CheckedListBox TaxiListBox;
        private System.Windows.Forms.Label BusStopLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BusStopTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button AddPictureButton;
        private System.Windows.Forms.NumericUpDown YearNumericUpDown;
    }
}