using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.IO;

namespace Course
{
    class Program
    {
        //Относительные пути лучше
        //на другом пк может не быть данного пути
        static string Path = @"Sight1.txt";
        static void WriteInFile(List<Sight> Ls)
        {
            var element = File.ReadAllText(Path).Split('\n');
            using (TextWriter writer = new StreamWriter(Path, false))
            {
                Ls.ForEach(item =>{ writer.WriteLine(item.Name + "," + item.Text + "," + item.FIO + "," + item.Adres + "," + item.Create); });
            }
        }
        static void AddUpInFile(List<Sight> Ls,Sight s)
        {
            using (TextWriter writer = new StreamWriter(Path, true))
            {
                writer.WriteLine(s.Name + "," + s.Text + "," + s.FIO + "," + s.Adres + "," + s.Create);
                writer.Close();
            }
        }
        static List<Sight> ReadOnFile()
        {
            List<Sight> Ls = new List<Sight>();
            if (File.Exists(Path))
            {
                using (TextReader reader = new StreamReader(Path))
                {
                    string Lines = null;
                    while (true)
                    {
                        Lines = reader.ReadLine();
                        if (string.IsNullOrEmpty(Lines)) break;
                        string[] line = Lines.Split(',');
                        Sight newSight = new Sight();
                        newSight.Name = line[0];
                        newSight.Text = line[1];
                        newSight.FIO = line[2];
                        newSight.Adres = line[3];
                        newSight.Create = DateTime.Parse(line[4]);
                        Ls.Add(newSight);
                    }
                    reader.Dispose();
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
                //Console.WriteLine("Введите путь к файлу");
                //Path = Console.ReadLine();
                //if (string.IsNullOrWhiteSpace(Path))
                //{
                //    throw new Exception("Пустой путь недопустим!");
                //}
                List<Sight> ListSight = ReadOnFile();


                Sight sight = new Sight();
                sight.FillingSight(sight);
                AddUpInFile(ListSight, sight);
                Sight sight1 = new Sight();
                sight1.FillingSight(sight1);
                ListSight.Add(sight);
                ListSight.Add(sight1);
                
                Sight S = FindSight(ListSight);
                
                Console.WriteLine("\n");
                RemoveSight(ListSight);

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
