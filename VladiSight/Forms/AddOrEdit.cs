using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        /// <param name="entities">Список всех записей</param>
        /// <param name="ParamEntity">Обьект класса сущностей</param>
        /// <param name="view">Доступность только для просмотра</param>
        public AddOrEdit(List<EntityClassSight> entities, EntityClassSight ParamEntity = null, bool view = true)
        {
            InitializeComponent();
            if ((ParamEntity != null) && view)
            {
                DelButton.Visible = true;
                entity = ParamEntity;
                FormInit();
                EntityClases = entities;
                if (File.Exists(entity.Photo.Trim()))
                {
                    Image imgsight = Image.FromFile(entity.Photo.Trim());
                    PictureBox.Image = imgsight;
                    PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    Image imgsight = Image.FromFile("unnamed.png");
                    PictureBox.Image = imgsight;
                    PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                AddPictureButton.Text = "Изменить изображение";
                this.Text = "Изменение";
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
                if (File.Exists(entity.Photo.Trim()))
                {
                    Image imgsight = Image.FromFile(entity.Photo.Trim());
                    PictureBox.Image = imgsight;
                    PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    Image imgsight = Image.FromFile("unnamed.png");
                    PictureBox.Image = imgsight;
                    PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                SaveButton.Visible = false;
                NoVisible();
            }
            else
            {
                EntityClases = entities;
                SaveButton.Text = "Создать";
                this.Text = "Создание";
                DelButton.Visible = false;
            }
        }
        /// <summary>
        /// Изменение доступности для нажатия полей формы AddOrEdit
        /// </summary>
        private void NoVisible()
        {
            NameTextBox.Enabled = false;
            DiscriptionTextBox.Enabled = false;
            AuthorTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            YearNumericUpDown.Enabled = false;
            BusStopTextBox.Enabled = false;
            StatusComboBox.Enabled = false;
            AbusListBox1.Enabled = false;
            BusListBox1.Enabled = false;
            TaxiListBox.Enabled = false;
        }
        /// <summary>
        /// Заполнение полей формы AddOrEdit
        /// </summary>
        private void FormInit()
        {
            NameTextBox.Text = entity.Name;
            DiscriptionTextBox.Text = entity.Description;
            AuthorTextBox.Text = entity.FIO;
            AddressTextBox.Text = entity.Address;
            YearNumericUpDown.Value = entity.Create;
            AbusCheckedInit();
            BusCheckedInit();
            TaxiCheckedInit();
            NewOrEditetClass.Photo = entity.Photo;
            BusStopTextBox.Text = entity.BusStop;
            if (entity.Status.Trim() != "")
            {
                StatusComboBox.SelectedIndex = StatusValueInit(entity.Status);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NewOrEditetClass.Name = NameTextBox.Text;
        }
        private void DiscriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            NewOrEditetClass.Description = DiscriptionTextBox.Text;
        }
        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            NewOrEditetClass.FIO = AuthorTextBox.Text;
        }
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            NewOrEditetClass.Address = AddressTextBox.Text;
        }
        private void StatusComboBox_TextChanged(object sender, EventArgs e)
        {
            NewOrEditetClass.Status = StatusComboBox.Text;
        }
        private void BusStopTextBox_TextChanged(object sender, EventArgs e)
        {
            NewOrEditetClass.BusStop = BusStopTextBox.Text;
        }
        /// <summary>
        /// Проверка заполнения обязательных полей
        /// </summary>
        private bool CheckTextBox()
        {
            SaveAbusListBox();
            SaveBusListBox();
            SaveTaxiListBox();
            if (this.Text == "Изменение")
            {
                if ((!string.IsNullOrWhiteSpace(NameTextBox.Text))
                && (!string.IsNullOrWhiteSpace(AuthorTextBox.Text)) && (!string.IsNullOrWhiteSpace(AddressTextBox.Text))
                && (!string.IsNullOrWhiteSpace(DiscriptionTextBox.Text)) && (!string.IsNullOrEmpty(StatusComboBox.Text))
                && (!string.IsNullOrEmpty(BusStopTextBox.Text)) && (entity.Create != 0)
                && (!string.IsNullOrEmpty(entity.Abus)) && (!string.IsNullOrEmpty(entity.Bus))
                && (!string.IsNullOrEmpty(entity.Taxi)) && (!string.IsNullOrEmpty(entity.Photo)))
                {
                    SaveButton.Visible = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((!string.IsNullOrWhiteSpace(NameTextBox.Text))
                && (!string.IsNullOrWhiteSpace(AuthorTextBox.Text)) && (!string.IsNullOrWhiteSpace(AddressTextBox.Text))
                && (!string.IsNullOrWhiteSpace(DiscriptionTextBox.Text)) && (!string.IsNullOrEmpty(StatusComboBox.Text))
                && (!string.IsNullOrEmpty(BusStopTextBox.Text)) && (NewOrEditetClass.Create != 0)
                && (!string.IsNullOrEmpty(NewOrEditetClass.Abus)) && (!string.IsNullOrEmpty(NewOrEditetClass.Bus))
                && (!string.IsNullOrEmpty(NewOrEditetClass.Taxi)) && (!string.IsNullOrEmpty(NewOrEditetClass.Photo)))
                {
                    SaveButton.Visible = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                if (entity == null)
                {
                    foreach (EntityClassSight item in EntityClases)
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
                    int id = EntityClases.IndexOf(entity);
                    EntityClases[id] = NewOrEditetClass;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Не все обязательные поля заполнены! \nПроверьте введенные данные.");
            }
        }
        private void DelButton_Click(object sender, EventArgs e)
        {
            EntityClases.Remove(entity);
            this.Close();
        }
        /// <summary>
        /// Запись выбранных полей автобусов в строку
        /// </summary>
        private bool SaveAbusListBox()
        {

            NewOrEditetClass.Abus = "";
            if (AbusListBox1.CheckedItems.Count > 0)
            {
                foreach (string itemCheck in AbusListBox1.CheckedItems)
                {
                    if (itemCheck == "нет")
                    {
                        NewOrEditetClass.Abus = "нет";
                        break;
                    }
                    NewOrEditetClass.Abus += itemCheck + " ";
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Запись выбранных полей троллейбусов в строку
        /// </summary>
        private bool SaveBusListBox()
        {
            NewOrEditetClass.Bus = "";
            if (BusListBox1.CheckedItems.Count > 0)
            {
                foreach (string itemCheck in BusListBox1.CheckedItems)
                {
                    if (itemCheck == "нет")
                    {
                        NewOrEditetClass.Bus = "нет";
                        break;
                    }
                    NewOrEditetClass.Bus += itemCheck + " ";
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Запись выбранных полей маршруток в строку
        /// </summary>
        private bool SaveTaxiListBox()
        {
            NewOrEditetClass.Taxi = "";
            if (TaxiListBox.CheckedItems.Count > 0)
            {
                foreach (string itemCheck in TaxiListBox.CheckedItems)
                {
                    if (itemCheck == "нет")
                    {
                        NewOrEditetClass.Taxi = "нет";
                        break;
                    }
                    NewOrEditetClass.Taxi += itemCheck + " ";
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Заполнение поля "Статус" выбранным ранее значением
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        private int StatusValueInit(string status)
        {
            int i = 0;
            foreach (string item in StatusComboBox.Items)
            {
                if (status.Trim() == item)
                {
                    return i;
                }
                i++;
            }
            return -i;
        }
        /// <summary>
        /// Выбор выбранных ранее автобусов
        /// </summary>
        private void AbusCheckedInit()
        {
            string[] check = entity.Abus.Split(' ');
            foreach (string item in check)
            {
                switch (item)
                {
                    case "нет":
                        {
                            for(int i=0; i<AbusListBox1.Items.Count-1; i++)
                            {
                                AbusListBox1.SetItemChecked(i, false);
                            }
                            AbusListBox1.SetItemChecked(AbusListBox1.Items.Count - 1, true);
                            return;
                        }
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
        /// <summary>
        /// Заполнение выбранных ранее маршруток
        /// </summary>
        private void TaxiCheckedInit()
        {
            string[] check = entity.Taxi.Split(' ');
            foreach (string item in check)
            {
                switch (item)
                {
                    case "нет":
                        {
                            for (int i = 0; i < TaxiListBox.Items.Count - 1; i++)
                            {
                                TaxiListBox.SetItemChecked(i, false);
                            }
                            TaxiListBox.SetItemChecked(TaxiListBox.Items.Count - 1, true);
                            return;
                        }
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
        /// <summary>
        /// Заполнение выбранных ранее троллейбусов
        /// </summary>
        private void BusCheckedInit()
        {
            string[] check = entity.Bus.Split(' ');
            foreach (string item in check)
            {
                switch (item)
                {
                    case "нет":
                        {
                            for (int i = 0; i < BusListBox1.Items.Count - 1; i++)
                            {
                                BusListBox1.SetItemChecked(i, false);
                            }
                            BusListBox1.SetItemChecked(BusListBox1.Items.Count - 1, true);
                            return;
                        }
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
            openFileDialog.Filter = "Файлы изображений|*.png;*.jpg;*jpeg";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (File.Exists(openFileDialog.FileName))
            {
                Image imgsight = Image.FromFile(openFileDialog.FileName);
                PictureBox.Image = imgsight;
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                Image imgsight = Image.FromFile("unnamed.png");
                PictureBox.Image = imgsight;
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            NewOrEditetClass.Photo = openFileDialog.FileName;
            AddPictureButton.Text = "Изменить изображение";
        }

        private void YearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NewOrEditetClass.Create = Convert.ToInt32(YearNumericUpDown.Value);
        }
    }
}
