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

        public void Fill()
        {
            Console.Write("Введите название достопримечательности: ");
            Name = Console.ReadLine();
            Console.Write("Введите описание достопримечательности: ");
            Text = Console.ReadLine();
            Console.Write("Введите ФИО автора достопримечательности: ");
            FIO = Console.ReadLine();
            Console.Write("Введите адрес достопримечательности: ");
            Adres = Console.ReadLine();
            Console.Write("Введите дату создания достопримечательности: ");
            Create = DateTime.Parse(Console.ReadLine());

        }
        public void Print()
        {
            Console.WriteLine($"ФИО автора достопримечательности: {FIO}");
            Console.WriteLine($"Описание достопримечательности: {Text}");
            Console.WriteLine($"Название достопримечательности: {Name}");
            Console.WriteLine($"Адрес достопримечательности: {Adres}" );
            Console.WriteLine($"Дата создания достопримечательности: {Create}\n");
        }



    }
}
