using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static string Path = "";
        static void WriteInFile(List<Sight> Ls)
        {
            using (TextWriter writer = new StreamWriter(Path, false))
            {
                using (TextReader reader = new StreamReader(Path))
                {

                    while (true)
                    {
                        var element = reader.ReadLine();
                        if (element == null)
                            break;
                        var parsedEllement = element.Split(',');
                        if (Ls.Select(c => c.Name == parsedEllement[0]).Count() > 0)
                        {
                            Console.WriteLine("Запись уже существует!");
                            break;
                        }

                    }

                }
                Ls.ForEach(item =>
                {

                    writer.WriteLine(item.Name + "," + item.Text + "," + item.FIO + "," + item.Adres + "," + item.Create);

                });

            }
        }
        static void AddUpInFile(Sight s)
        {
            using (TextWriter writer = new StreamWriter(Path, true))
            {
                writer.WriteLine(s.Name + "," + s.Text + "," + s.FIO + "," + s.Adres + "," + s.Create);
            }
        }
        static List<Sight> ReadOnFile()
        {
            List<Sight> Ls = new List<Sight>();
            if (File.Exists(Path))
            {
                using (TextReader reader = new StreamReader(Path))
                {
                    string AllLines = null;
                    while (true)
                    {
                        AllLines = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(AllLines)) break;
                        string[] lines = AllLines.Split(',');
                        Sight newSight = new Sight();
                        newSight.Name = lines[0];
                        newSight.Text = lines[1];
                        newSight.FIO = lines[2];
                        newSight.Adres = lines[3];
                        newSight.Create = DateTime.Parse(lines[4]);
                        Ls.Add(newSight);

                    }
                }
                return Ls;
            }
            else
            {
                throw new Exception("Файл не существует!");
            }
        }
        static void ChangeSight(List<Sight> Ls)
        {
            Console.WriteLine("Изменение: ");
            Sight help = FindSight(Ls);
            if (help != null)
            {
                Console.Write("Введите название достопримечательности: ");
                help.Name = Console.ReadLine();
                Console.Write("Введите описание достопримечательности: ");
                help.Text = Console.ReadLine();
                Console.Write("Введите ФИО автора достопримечательности: ");
                help.FIO = Console.ReadLine();
                Console.Write("Введите адрес достопримечательности: ");
                help.Adres = Console.ReadLine();
                Console.Write("Введите дату создания достопримечательности: ");
                help.Create = DateTime.Parse(Console.ReadLine());
            }
            else Console.WriteLine("Такой достопримечательности нет");
        }
        static void RemoveSight(List<Sight> Ls)
        {
            Console.WriteLine("Удаление: ");
            Sight help = FindSight(Ls);
            if (help != null)
                Ls.Remove(help);
            else Console.WriteLine("Такой достопримечательности нет");
        }
        static Sight FindSight(List<Sight> Ls)
        {
            Console.Write("Введите название достопримечательности: ");
            string searchSight = Console.ReadLine();
            var findElements = Ls.FindAll(c => c.Name == searchSight);
            if (Ls.Find(item => item.Name == searchSight) != null)
            {
                return Ls.Find(item => item.Name == searchSight);
            }
            return null;
        }


        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Введите путь к файлу");
                Path = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Path))
                {
                    throw new Exception("Пустой путь недопустим!");
                }
                List<Sight> ListSight = ReadOnFile();

                ListSight.ForEach(item => item.Print());

                //Sight sight = new Sight();
                //AddUpInFile(sight);
                //ListSight.Add(sight);
                //for (int i = 0; i < ListSight.Count; i++)
                //{
                //    ListSight[i].Print();
                //}
                //Sight S = FindSight(ListSight);
                //if (S == null)
                //    Console.WriteLine("Такой достопримечательности нет");
                //else S.Print();
                Console.WriteLine("\n");
                RemoveSight(ListSight);
                ListSight.ForEach(item => item.Print());
                ChangeSight(ListSight);
                WriteInFile(ListSight);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

            }

        }
    }
}
