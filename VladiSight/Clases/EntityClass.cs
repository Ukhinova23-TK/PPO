using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace VladiSight.Clases
{
    public class EntityClassSight
    {
        private string _name;
        private string _description;
        private string _fio;
        private string _adres;
        private int _create;
        private string _abus;
        private string _bus;
        private string _taxi;
        private string _busStop;
        private string _status;
        private string _photo;

        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string FIO { get { return _fio; } set { _fio = value; } }
        public string Address { get { return _adres; } set { _adres = value; } }
        public int Create { get { return _create; } set { _create = value; } }
        public string Abus { get { return _abus; } set { _abus = value; } }
        public string Bus { get { return _bus; } set { _bus = value; } }
        public string Taxi { get { return _taxi; } set { _taxi = value; } }
        public string BusStop { get { return _busStop; } set { _busStop = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public string Photo { get { return _photo; } set { _photo = value; } }

        /// <summary>
        /// Инициаизация объекта значениями
        /// </summary>
        /// <param name="Photo">Изображение</param>
        /// <param name="Name">Название достопримечательности</param>
        /// <param name="Description">Описание достопримечательности</param>
        /// <param name="FIO">Автор достопримечтальеонсти</param>
        /// <param name="Adres">Место нахождения достопримечательности</param>
        /// <param name="Create">Дата создания</param>
        /// <param name="Abus">Автобусы</param>
        /// <param name="Bus">Троллейбусы</param>
        /// <param name="Taxi">Маршрутное такси</param>
        /// <param name="BusStop">Остановка</param>
        /// <param name="Status">Сатус</param>
        public EntityClassSight(string Photo, string Name, string Description, string FIO, string Adres, int Create, string Abus, string Bus, string Taxi, string BusStop, string Status)
        {
            this.Name = Name;
            this.Description = Description;
            this.FIO = FIO;
            this.Address = Adres;
            this.Create = Create;
            this.Abus = Abus;
            this.Bus = Bus;
            this.Taxi = Taxi;
            this.BusStop = BusStop;
            this.Status = Status;
            this.Photo = Photo;
        }
        /// <summary>
        /// Пустой конструктор, значения устанавливаются по умолчанию
        /// </summary>
        public EntityClassSight()
        {
            this.Name = "";
            this.Description = "";
            this.FIO = "";
            this.Address = "";
            this.Create = 0;
            this.Abus = "";
            this.Bus = "";
            this.Taxi = "";
            this.BusStop = "";
            this.Status = "";
            this.Photo = "";
        }

        public static EntityClassSight ToEntityClass(string s)
        {
            string[] splitStr = s.Split(new string[] { "<split>" }, StringSplitOptions.RemoveEmptyEntries);
            int year = Convert.ToInt32(splitStr[5]);
            EntityClassSight entity = new EntityClassSight(splitStr[0], splitStr[1], splitStr[2], splitStr[3], splitStr[4], year, splitStr[6], splitStr[7], splitStr[8], splitStr[9], splitStr[10]);
            return entity;
        }

        public override string ToString()
        {
            string separator = "<split>";
            string entity = Photo + separator + Name + separator + Description + separator + FIO + separator + Address + separator + Create + separator + Abus + separator + Bus + separator + Taxi + separator + BusStop + separator + Status + "<br>";
            return entity;
        }

        public bool Equally(EntityClassSight entity)
        {
            if (entity == null)
            {
                return false;
            }
            if ((entity.Name == this.Name) && (entity.Description == this.Description) && (entity.FIO == this.FIO) && (entity.Address == this.Address) && (entity.Create == this.Create))
            {
                return true;
            }
            else return false;
        }
    }
}
