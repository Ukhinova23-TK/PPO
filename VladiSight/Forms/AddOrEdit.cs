using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VladiSight.Clases;

namespace VladiSight.Forms
{
    public partial class AddOrEdit : Form
    {
        private EntityClassSight entity = null;
        private EntityClassSight NewOrEditetClass = new EntityClassSight();
        public static List<EntityClassSight> EntityClases;
        /// <summary>
        /// Инициализация окна 
        /// </summary>
        /// <param name="entities"> список всех записей</param>
        /// <param name="ParamEntity"> обьект класса сущностей</param>
        public AddOrEdit(List<EntityClassSight> entities, EntityClassSight ParamEntity = null, bool view = true)
        {
            InitializeComponent();
            if ((ParamEntity != null) && view)
            {
                DelButton.Visible = true;
                entity = ParamEntity;
                FormInit();
                EntityClases = entities;
                Image imgsight = Image.FromFile(entity.Photo);
                Bitmap bmp = new Bitmap(imgsight, PictureBox.Width, PictureBox.Height);
                PictureBox.Image = bmp;
                if (string.IsNullOrEmpty(NewOrEditetClass.Photo))
                {
                    AddPictureButton.Text = "Изменить изображение";
                }
                this.Text = "Изменение";
                CheckTextBox();
            }
            else if ((ParamEntity != null) && (!view))
            {
                DelButton.Visible = false;
                AddPictureButton.Visible = false;
                CloseButton.Text = "Назад";
                this.Text = "Просмотр";
                entity = ParamEntity;
                FormInit();
                EntityClases = entities;
                Image imgsight = Image.FromFile(entity.Photo);
                Bitmap bmp = new Bitmap(imgsight, PictureBox.Width, PictureBox.Height);
                PictureBox.Image = bmp;
                CheckTextBox();
                SaveButton.Visible = false;
                NoVisible();
            }
            else
            {
                EntityClases = entities;
                SaveButton.Text = "Создать";
                this.Text = "Создание";
                SaveButton.Visible = false;
                DelButton.Visible = false;
                dateTimePicker.Value = DateTime.Today;
                NewOrEditetClass.Create = dateTimePicker.Value;
                //CheckTextBox();
            }
        }

        private void NoVisible()
        {
            NameTextBox.Enabled = false;
            DiscriptionTextBox.Enabled = false;
            AuthorTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            dateTimePicker.Enabled = false;
            BusStopTextBox.Enabled = false;
            StatusComboBox.Enabled = false;
            AbusListBox1.Enabled = false;
            BusListBox1.Enabled = false;
            TaxiListBox.Enabled = false;
        }

        private void FormInit()
        {
            NameTextBox.Text = entity.Name;
            DiscriptionTextBox.Text = entity.Description;
            AuthorTextBox.Text = entity.FIO;
            AddressTextBox.Text = entity.Address;
            dateTimePicker.Value = entity.Create;
            AbusCheckedInit();
            BusCheckedInit();
            TaxiCheckedInit();
            BusStopTextBox.Text = entity.BusStop;
            if (entity.Status.Trim() != "")
            {
                StatusComboBox.SelectedIndex = StatusValueInit(entity.Status);
            }
            CheckTextBox();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                NewOrEditetClass.Name = NameTextBox.Text;
            }
            else { SaveButton.Visible = false; }
            CheckTextBox();
        }
        private void DiscriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DiscriptionTextBox.Text))
            {
                NewOrEditetClass.Description = DiscriptionTextBox.Text;
            }
            else { SaveButton.Visible = false; }
            CheckTextBox();
        }
        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AuthorTextBox.Text))
            {
                NewOrEditetClass.FIO = AuthorTextBox.Text;
            }
            else { SaveButton.Visible = false; }
            CheckTextBox();
        }
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                NewOrEditetClass.Address = AddressTextBox.Text;
            }
            else { SaveButton.Visible = false; }
            CheckTextBox();
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            NewOrEditetClass.Create = dateTimePicker.Value;
        }
        private void StatusComboBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(StatusComboBox.Text))
            {
                NewOrEditetClass.Status = StatusComboBox.Text;
            }
        }
        private void BusStopTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BusStopTextBox.Text))
            {
                NewOrEditetClass.BusStop = BusStopTextBox.Text;
            }
        }
        private void CheckTextBox()
        {
            if ((!string.IsNullOrEmpty(NewOrEditetClass.Photo)) && (!string.IsNullOrWhiteSpace(NameTextBox.Text)) && (!string.IsNullOrWhiteSpace(AuthorTextBox.Text)) && (!string.IsNullOrWhiteSpace(AddressTextBox.Text)) && (!string.IsNullOrWhiteSpace(DiscriptionTextBox.Text)))
            {
                SaveButton.Visible = true;
            }
            if((string.IsNullOrEmpty(NewOrEditetClass.Photo)) && (string.IsNullOrWhiteSpace(NameTextBox.Text)) && (string.IsNullOrWhiteSpace(AuthorTextBox.Text)) && (string.IsNullOrWhiteSpace(AddressTextBox.Text)) && (string.IsNullOrWhiteSpace(DiscriptionTextBox.Text)))
            {
                SaveButton.Visible = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (entity == null)
            {
                SaveAbusListBox();
                SaveBusListBox();
                SaveTaxiListBox();
                foreach(EntityClassSight item in EntityClases)
                {
                    if (NewOrEditetClass.Equally(item))
                    {
                        this.Close();
                        return;
                    }
                }
                EntityClases.Add(NewOrEditetClass);
            }
            else
            {
                SaveAbusListBox();
                SaveBusListBox();
                SaveTaxiListBox();
                int id = EntityClases.IndexOf(entity);
                EntityClases[id] = NewOrEditetClass;
            }
            this.Close();
        }
        private void DelButton_Click(object sender, EventArgs e)
        {
            EntityClases.Remove(entity);
            this.Close();
        }

        private void SaveAbusListBox()
        {
            foreach (string itemCheck in AbusListBox1.CheckedItems)
            {
                NewOrEditetClass.Abus += itemCheck + " ";
            }
        }
        private void SaveBusListBox()
        {
            foreach (string itemCheck in BusListBox1.CheckedItems)
            {
                NewOrEditetClass.Bus += itemCheck + " ";
            }
        }
        private void SaveTaxiListBox()
        {
            foreach(string itemCheck in TaxiListBox.CheckedItems)
            {
                NewOrEditetClass.Taxi += itemCheck + " ";
            }
        }
        
        private int StatusValueInit(string status)
        {
            int i = 0;
            foreach(string item in StatusComboBox.Items)
            {
                if (status.Trim() == item)
                {
                    return i;
                }
                i++;
            }
            return -i;
        }

        private void AbusCheckedInit()
        {
            string[] check = entity.Abus.Split(' ');
            foreach (string item in check)
            {
                switch (item)
                {
                    case "1с":
                        {
                            AbusListBox1.SetItemChecked(0, true);
                            break;
                        }
                    case "2":
                        {
                            AbusListBox1.SetItemChecked(1, true);
                            break;
                        }
                    case "6с":
                        {
                            AbusListBox1.SetItemChecked(2, true);
                            break;
                        }
                    case "7с":
                        {
                            AbusListBox1.SetItemChecked(3, true);
                            break;
                        }
                    case "11":
                        {
                            AbusListBox1.SetItemChecked(4, true);
                            break;
                        }
                    case "14":
                        {
                            AbusListBox1.SetItemChecked(5, true);
                            break;
                        }
                    case "15":
                        {
                            AbusListBox1.SetItemChecked(6, true);
                            break;
                        }
                    case "17":
                        {
                            AbusListBox1.SetItemChecked(7, true);
                            break;
                        }
                    case "18с":
                        {
                            AbusListBox1.SetItemChecked(8, true);
                            break;
                        }
                    case "20с":
                        {
                            AbusListBox1.SetItemChecked(9, true);
                            break;
                        }
                    case "21с":
                        {
                            AbusListBox1.SetItemChecked(10, true);
                            break;
                        }
                    case "22":
                        {
                            AbusListBox1.SetItemChecked(11, true);
                            break;
                        }
                    case "23":
                        {
                            AbusListBox1.SetItemChecked(12, true);
                            break;
                        }
                    case "24с":
                        {
                            AbusListBox1.SetItemChecked(13, true);
                            break;
                        }
                    case "25":
                        {
                            AbusListBox1.SetItemChecked(14, true);
                            break;
                        }
                    case "26":
                        {
                            AbusListBox1.SetItemChecked(15, true);
                            break;
                        }
                    case "27":
                        {
                            AbusListBox1.SetItemChecked(16, true);
                            break;
                        }
                    case "28":
                        {
                            AbusListBox1.SetItemChecked(17, true);
                            break;
                        }
                    case "29с":
                        {
                            AbusListBox1.SetItemChecked(18, true);
                            break;
                        }
                    case "32":
                        {
                            AbusListBox1.SetItemChecked(19, true);
                            break;
                        }
                }
            }
        }
        private void TaxiCheckedInit()
        {
            string[] check = entity.Taxi.Split(' ');
            foreach(string item in check)
            {
                switch (item)
                {
                    case "5":
                        {
                            TaxiListBox.SetItemChecked(0, true);
                            break;
                        }
                    case "36":
                        {
                            TaxiListBox.SetItemChecked(0, true);
                            break;
                        }
                }
            }
        }
        private void BusCheckedInit()
        {
            string[] check = entity.Bus.Split(' ');
            foreach (string item in check)
            {
                switch (item)
                {
                    case "1":
                        {
                            BusListBox1.SetItemChecked(0, true);
                            break;
                        }
                    case "2":
                        {
                            BusListBox1.SetItemChecked(1, true);
                            break;
                        }
                    case "5":
                        {
                            BusListBox1.SetItemChecked(2, true);
                            break;
                        }
                    case "7":
                        {
                            BusListBox1.SetItemChecked(3, true);
                            break;
                        }
                    case "8":
                        {
                            BusListBox1.SetItemChecked(4, true);
                            break;
                        }
                    case "10":
                        {
                            BusListBox1.SetItemChecked(5, true);
                            break;
                        }
                    case "11":
                        {
                            BusListBox1.SetItemChecked(6, true);
                            break;
                        }
                    case "12":
                        {
                            BusListBox1.SetItemChecked(7, true);
                            break;
                        }
                }
            }
        }

        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewOrEditetClass.Photo))
            {
                AddPictureButton.Text = "Изменить изображение";
            }
            openFileDialog.Filter = "Файлы изображений|*.png;*.jpg";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Image imgsight = Image.FromFile(openFileDialog.FileName);
            Bitmap bmp = new Bitmap(imgsight, PictureBox.Width, PictureBox.Height);
            PictureBox.Image = bmp;
            NewOrEditetClass.Photo = openFileDialog.FileName;
            CheckTextBox();
        }
    }
}
