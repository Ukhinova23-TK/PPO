namespace VladiSight
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.FileDropDownMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DGVDropDownMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.nameFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.nameFilterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.authorFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.authorFilterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.addresFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.addresFilterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.StatusFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusFilterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addRecordButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteDataButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDropDownMenu,
            this.toolStripSeparator1,
            this.DGVDropDownMenu,
            this.toolStripSeparator2,
            this.addRecordButton,
            this.toolStripSeparator3,
            this.ClearButton,
            this.toolStripSeparator4,
            this.DeleteDataButton,
            this.toolStripSeparator5,
            this.ViewButton,
            this.toolStripSeparator6,
            this.EditButton,
            this.toolStripSeparator7});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainToolStrip.Size = new System.Drawing.Size(1051, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // FileDropDownMenu
            // 
            this.FileDropDownMenu.BackColor = System.Drawing.SystemColors.Control;
            this.FileDropDownMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileDropDownMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpen,
            this.saveFileToolStripMenuItem,
            this.createFileToolStripMenuItem});
            this.FileDropDownMenu.Image = ((System.Drawing.Image)(resources.GetObject("FileDropDownMenu.Image")));
            this.FileDropDownMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileDropDownMenu.Name = "FileDropDownMenu";
            this.FileDropDownMenu.Size = new System.Drawing.Size(115, 22);
            this.FileDropDownMenu.Text = "Работа с файлом";
            // 
            // FileOpen
            // 
            this.FileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(164, 22);
            this.FileOpen.Text = "Открыть файл";
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveFileToolStripMenuItem.Text = "Сохранить файл";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // createFileToolStripMenuItem
            // 
            this.createFileToolStripMenuItem.Name = "createFileToolStripMenuItem";
            this.createFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.createFileToolStripMenuItem.Text = "Создать файл";
            this.createFileToolStripMenuItem.Click += new System.EventHandler(this.createFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // DGVDropDownMenu
            // 
            this.DGVDropDownMenu.BackColor = System.Drawing.Color.OldLace;
            this.DGVDropDownMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DGVDropDownMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameFilter,
            this.authorFilter,
            this.addresFilter,
            this.StatusFilter});
            this.DGVDropDownMenu.Image = ((System.Drawing.Image)(resources.GetObject("DGVDropDownMenu.Image")));
            this.DGVDropDownMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DGVDropDownMenu.Name = "DGVDropDownMenu";
            this.DGVDropDownMenu.Size = new System.Drawing.Size(61, 22);
            this.DGVDropDownMenu.Text = "Фильтр";
            // 
            // nameFilter
            // 
            this.nameFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameFilterTextBox});
            this.nameFilter.Name = "nameFilter";
            this.nameFilter.Size = new System.Drawing.Size(178, 22);
            this.nameFilter.Text = "Название";
            // 
            // nameFilterTextBox
            // 
            this.nameFilterTextBox.Name = "nameFilterTextBox";
            this.nameFilterTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameFilterTextBox.TextChanged += new System.EventHandler(this.nameFilterTextBox_TextChanged);
            // 
            // authorFilter
            // 
            this.authorFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorFilterTextBox});
            this.authorFilter.Name = "authorFilter";
            this.authorFilter.Size = new System.Drawing.Size(178, 22);
            this.authorFilter.Text = "Автор";
            // 
            // authorFilterTextBox
            // 
            this.authorFilterTextBox.Name = "authorFilterTextBox";
            this.authorFilterTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorFilterTextBox.TextChanged += new System.EventHandler(this.authorFilterTextBox_TextChanged);
            // 
            // addresFilter
            // 
            this.addresFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addresFilterTextBox});
            this.addresFilter.Name = "addresFilter";
            this.addresFilter.Size = new System.Drawing.Size(178, 22);
            this.addresFilter.Text = "Место нахождения";
            // 
            // addresFilterTextBox
            // 
            this.addresFilterTextBox.Name = "addresFilterTextBox";
            this.addresFilterTextBox.Size = new System.Drawing.Size(100, 23);
            this.addresFilterTextBox.TextChanged += new System.EventHandler(this.addresFilterTextBox_TextChanged);
            // 
            // StatusFilter
            // 
            this.StatusFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusFilterTextBox});
            this.StatusFilter.Name = "StatusFilter";
            this.StatusFilter.Size = new System.Drawing.Size(178, 22);
            this.StatusFilter.Text = "Статус";
            // 
            // StatusFilterTextBox
            // 
            this.StatusFilterTextBox.Name = "StatusFilterTextBox";
            this.StatusFilterTextBox.Size = new System.Drawing.Size(100, 23);
            this.StatusFilterTextBox.TextChanged += new System.EventHandler(this.StatusFilterTextBox_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addRecordButton
            // 
            this.addRecordButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("addRecordButton.Image")));
            this.addRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(106, 22);
            this.addRecordButton.Text = "Создать элемент ";
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(217)))), ((int)(((byte)(184)))));
            this.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(111, 22);
            this.ClearButton.Text = "Очистить таблицу";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(181)))), ((int)(((byte)(135)))));
            this.DeleteDataButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteDataButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteDataButton.Image")));
            this.DeleteDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(99, 22);
            this.DeleteDataButton.Text = "Удалить данные";
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(156)))), ((int)(((byte)(97)))));
            this.ViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ViewButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewButton.Image")));
            this.ViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(78, 22);
            this.ViewButton.Text = "Посмотреть";
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(142)))), ((int)(((byte)(84)))));
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(65, 22);
            this.EditButton.Text = "Изменить";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(5, 29);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1043, 427);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // MainOpenFileDialog
            // 
            this.MainOpenFileDialog.DefaultExt = "*.txt";
            this.MainOpenFileDialog.Filter = "txt-files|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "*.txt";
            this.saveFileDialog.Filter = "txt-files|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 467);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.MainToolStrip);
            this.MaximumSize = new System.Drawing.Size(2000, 506);
            this.MinimumSize = new System.Drawing.Size(1064, 506);
            this.Name = "MainForm";
            this.Text = "Список достопримечательностей города Владимира";
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog MainOpenFileDialog;
        private System.Windows.Forms.ToolStripDropDownButton FileDropDownMenu;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripDropDownButton DGVDropDownMenu;
        private System.Windows.Forms.ToolStripMenuItem nameFilter;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem authorFilter;
        private System.Windows.Forms.ToolStripMenuItem addresFilter;
        private System.Windows.Forms.ToolStripButton addRecordButton;
        private System.Windows.Forms.ToolStripButton ClearButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox nameFilterTextBox;
        private System.Windows.Forms.ToolStripTextBox authorFilterTextBox;
        private System.Windows.Forms.ToolStripTextBox addresFilterTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem StatusFilter;
        private System.Windows.Forms.ToolStripTextBox StatusFilterTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton DeleteDataButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ViewButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}

