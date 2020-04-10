using System;
using System.Collections.Generic;
using System.IO;


namespace VladiSight.Clases
{
    public static class ParseDataClass
    {
        /// <summary>
        /// Статический метод для парсинга данных
        /// </summary>
        /// <param name="FileName">Путь к файлу</param>
        /// <returns> List<string> </returns>
        public static List<EntityClassSight> ParseData(string FileName)
        {
            string[] AllText = File.ReadAllText(FileName).Split('\n');
            List<EntityClassSight> ParsedData = new List<EntityClassSight>();
            foreach (string str in AllText)
            {
                if (!string.IsNullOrWhiteSpace(str))
                {
                    string[] entity = str.Split(';');
                    DateTime date = DateTime.Parse(entity[5]);
                    ParsedData.Add(new EntityClassSight(entity[0], entity[1], entity[2], entity[3], entity[4], date, entity[6], entity[7], entity[8], entity[9], entity[10]));
                }
            }
            return ParsedData;
        }
        public static void SaveFile(List<EntityClassSight> sights, string path)
        {
            if(sights!=null && sights.Count >= 0)
            {
                using(TextWriter writer = new StreamWriter(path))
                {
                    foreach (EntityClassSight sight in sights)
                    {
                        writer.WriteLine(sight.ToString());
                    }
                }
            }
        }
    }
}
