using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VladiSight.Clases;
using VladiSight.Forms;

namespace VladiSight
{
    public partial class MainForm : Form
    {
        static List<EntityClassSight> entitys;
        static string path = "";
        /// <summary>
        /// Инициализация окна
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            addRecordButton.Enabled = false;
            ClearButton.Enabled = false;
            DeleteDataButton.Enabled = false;
            EditButton.Enabled = false;
            ViewButton.Enabled = false;
        }
        /// <summary>
        /// Создание таблицы данных
        /// </summary>
        /// <param name="ParsedData"></param>
        private void InitDGV(List<EntityClassSight> ParsedData)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = ParsedData.GetRange(0, ParsedData.Count);
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[0].HeaderText = "Название";
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[1].HeaderText = "Описание";
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[2].HeaderText = "Автор";
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[3].HeaderText = "Место нахождения";
            dataGridView.Columns[4].Width = 80;
            dataGridView.Columns[4].HeaderText = "Дата создания";
            dataGridView.Columns[5].Width = 90;
            dataGridView.Columns[5].HeaderText = "Автобусы";
            dataGridView.Columns[6].Width = 90;
            dataGridView.Columns[6].HeaderText = "Троллейбусы";
            dataGridView.Columns[7].Width = 90;
            dataGridView.Columns[7].HeaderText = "Маршрутные такси";
            dataGridView.Columns[8].Width = 100;
            dataGridView.Columns[8].HeaderText = "Остановка";
            dataGridView.Columns[9].Width = 100;
            dataGridView.Columns[9].HeaderText = "Статус";
            dataGridView.Columns[10].Visible = false;
            entitys = ParsedData;
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<EntityClassSight> ParsedData = ParseDataClass.ParseData(MainOpenFileDialog.FileName);
                InitDGV(ParsedData);
                addRecordButton.Enabled = true;
                ClearButton.Enabled = true;
                DeleteDataButton.Enabled = true;
                ViewButton.Enabled = true;
                EditButton.Enabled = true;
            }
            path = MainOpenFileDialog.FileName;

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EntityClassSight entity = dataGridView.Rows[e.RowIndex].DataBoundItem as EntityClassSight;
                AddOrEdit AddOrEditForm = new AddOrEdit(entitys, entity);
                AddOrEditForm.ShowDialog(this);
                if (AddOrEdit.EntityClases != null)
                {
                    InitDGV(AddOrEdit.EntityClases);
                }
            }
        }
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParseDataClass.SaveFile(entitys, path);
        }
        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.CreateText(saveFileDialog.FileName).Close();
                List<EntityClassSight> ParsedData = ParseDataClass.ParseData(saveFileDialog.FileName);
                InitDGV(ParsedData);
                addRecordButton.Enabled = true;
                ClearButton.Enabled = true;
                DeleteDataButton.Enabled = true;
                ViewButton.Enabled = true;
                EditButton.Enabled = true;
            }
            path = saveFileDialog.FileName;
        }

        private void nameFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.DataSource != null)
            {
                if (!string.IsNullOrWhiteSpace(nameFilterTextBox.Text))
                {
                    dataGridView.DataSource = entitys.Where(c => c.Name.Contains(nameFilterTextBox.Text)).ToList<EntityClassSight>();
                }
                else
                {
                    dataGridView.DataSource = entitys;
                }
            }
        }
        private void authorFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.DataSource != null)
            {
                if (!string.IsNullOrWhiteSpace(authorFilterTextBox.Text))
                {
                    dataGridView.DataSource = entitys.Where(c => c.FIO.Contains(authorFilterTextBox.Text)).ToList<EntityClassSight>();
                }
                else
                {
                    dataGridView.DataSource = entitys;
                }
            }
        }
        private void addresFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.DataSource != null)
            {
                if (!string.IsNullOrWhiteSpace(addresFilterTextBox.Text))
                {
                    dataGridView.DataSource = entitys.Where(c => c.Address.Contains(addresFilterTextBox.Text)).ToList<EntityClassSight>();
                }
                else
                {
                    dataGridView.DataSource = entitys;
                }
            }
        }
        private void StatusFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.DataSource != null)
            {
                if (!string.IsNullOrWhiteSpace(StatusFilterTextBox.Text))
                {
                    dataGridView.DataSource = entitys.Where(c => c.Status.Contains(StatusFilterTextBox.Text)).ToList<EntityClassSight>();
                }
                else
                {
                    dataGridView.DataSource = entitys;
                }
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            entitys = null;
            addRecordButton.Enabled = false;
            ClearButton.Enabled = false;
            DeleteDataButton.Enabled = false;
            ViewButton.Enabled = false;
            EditButton.Enabled = false;
        }
        private void addRecordButton_Click(object sender, EventArgs e)
        {
            var AddOrEditForm = new AddOrEdit(entitys);
            AddOrEditForm.ShowDialog(this);
            if (AddOrEdit.EntityClases != null)
            {
                InitDGV(AddOrEdit.EntityClases);
            }
        }
        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            if (entitys != null)
            {
                entitys.Clear();
                dataGridView.DataSource = null;
                addRecordButton.Enabled = false;
                ClearButton.Enabled = false;
                DeleteDataButton.Enabled = false;
                ViewButton.Enabled = false;
                EditButton.Enabled = false;
                File.Delete(path);
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                EntityClassSight entity = dataGridView.SelectedRows[0].DataBoundItem as EntityClassSight;
                AddOrEdit AddOrEditForm = new AddOrEdit(entitys, entity);
                AddOrEditForm.ShowDialog(this);
                if (AddOrEdit.EntityClases != null)
                {
                    InitDGV(AddOrEdit.EntityClases);
                }
            }
        }
        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                EntityClassSight entity = dataGridView.SelectedRows[0].DataBoundItem as EntityClassSight;
                AddOrEdit AddOrEditForm = new AddOrEdit(entitys, entity, false);
                AddOrEditForm.ShowDialog(this);
                if (AddOrEdit.EntityClases != null)
                {
                    InitDGV(AddOrEdit.EntityClases);
                }
            }
        }
    }
}
