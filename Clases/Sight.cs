using System;


namespace Course
{
    public class Sight
    {
        private string _fio;
        private string _text;
        private string _name;
        private string _adres;
        private DateTime _create;
        public string FIO { get { return _fio; } set { _fio = value; } }
        public string Text { get { return _text; } set { _text = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Adres { get { return _adres; } set { _adres = value; } }
        public DateTime Create { get { return _create; } set { _create = value; } }

        /// <summary>
        /// Инициализация объекта значениями
        /// </summary>
        /// <param name="FIO">ФИО создателя</param>
        /// <param name="Text">Информация о дост-ти</param>
        /// <param name="Name"> Название дост-ти</param>
        /// <param name="Adres">Адрес досто-ти</param>
        /// <param name="Create">ДатаСоздания</param>
        public Sight(string FIO, string Text, string Name, string Adres, DateTime Create)
        {
            this.FIO = FIO;
            this.Text = Text;
            this.Name = Name;
            this.Adres = Adres;
            this.Create = Create;
        }
        /// <summary>
        /// Пустой конструктор, значения устанавливаются по умолчанию
        /// </summary>
        public Sight() {
            this.FIO = "";
            this.Text = "";
            this.Name = "";
            this.Adres = "";
            this.Create = DateTime.MinValue;
        }

    }
}
