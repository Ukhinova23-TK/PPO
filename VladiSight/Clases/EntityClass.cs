using System;


namespace VladiSight.Clases
{
    public class EntityClassSight
    {
        private string _name;
        private string _description;
        private string _fio;
        private string _adres;
        private DateTime _create;
        private string _abus;
        private string _bus;
        private string _taxi;
        private string _busStop;
        private string _status;
        private object enetity;

        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string FIO { get { return _fio; } set { _fio = value; } }
        public string Address { get { return _adres; } set { _adres = value; } }
        public DateTime Create { get { return _create; } set { _create = value; } }
        public string Abus { get { return _abus; } set { _abus = value; } }
        public string Bus { get { return _bus; } set { _bus = value; } }
        public string Taxi { get { return _taxi; } set { _taxi = value; } }
        public string BusStop { get { return _busStop; } set { _busStop = value; } }
        public string Status { get { return _status; } set { _status = value; } }

        /// <summary>
        /// Инициаизация объекта значениями
        /// </summary>
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
        public EntityClassSight(string Name, string Description, string FIO, string Adres, DateTime Create, string Abus = "", string Bus = "", string Taxi = "", string BusStop = "", string Status = "")
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
            this.Create = DateTime.MinValue;
            this.Abus = "";
            this.Bus = "";
            this.Taxi = "";
            this.BusStop = "";
            this.Status = "";
        }

        public static EntityClassSight ToEntityClass(string s)
        {
            string[] splitStr = s.Split(',');
            DateTime date = DateTime.Parse(splitStr[4]);
            EntityClassSight entity = new EntityClassSight(splitStr[0], splitStr[1], splitStr[2], splitStr[3], date, splitStr[5], splitStr[6], splitStr[7], splitStr[8], splitStr[9]);
            return entity;
        }

        public override string ToString()
        {
            string entity = "";
            entity = Name + "," + Description + "," + FIO + "," + Address + "," + Create.ToString("dd.MM.yyyy") + "," + Abus + "," + Bus + "," + Taxi + "," + BusStop + "," + Status;
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
