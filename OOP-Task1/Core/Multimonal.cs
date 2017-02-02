using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace OOP_Task1.Core
{
    public class Multimonal
    {
        public int[] Array1 { get; set; }
        public int[] Array2 { get; set; }
        public int Lenght { get; set; }

        public void StartOperations()
        {
            ArraysFromFile();
            SaveFile();
        }
        /// <summary>
        /// Запись в файл
        /// </summary>
        public void SaveFile()
        {
            var stringToFile = "Multiplication result= "+ Multiplication()+ "\n"+ "Comparision result = "+Сomparison();

            using (var file = new StreamWriter(Path.GetFullPath(@"..\..\Files\write.txt")))
            {
                file.WriteLine(stringToFile);
            }
        }

        /// <summary>
        /// Чтение из файла
        /// </summary>
        public string[] ReadFile()
        {
            var strings=new List<string>();

            using (var file=new StreamReader(Path.GetFullPath(@"..\..\Files\read.txt")))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    strings.Add(line);
                }
            }
            return strings.ToArray();
        }
        /// <summary>
        /// Сравнение многочленов
        /// </summary>
        public bool Сomparison()
        {
            for (var i = 0; i < Lenght; i++)
            {
                if (i >= Array1.Length || i >= Array2.Length) continue;
                if (Array1[i] != Array2[i])
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Перемножение многочленов
        /// </summary>
        public string Multiplication()
        {
            var resultArray = new int[Lenght];

            for (var i = 0; i < Lenght; i++)
            {
                if (i < Array1.Length && i < Array2.Length)
                {
                    resultArray[i] = Array1[i] * Array2[i];
                }
            }
            var result = string.Join(",", resultArray);

            return result;
        }
        /// <summary>
        /// Массивы из файла
        /// </summary>
        public void ArraysFromFile()
        {
            var strings = ReadFile();

            var splitedM1 = strings[0].Split(',');
            var splitedM2 = strings[1].Split(',');

            Array1 = Array.ConvertAll(splitedM1, int.Parse);
            Array2 = Array.ConvertAll(splitedM2, int.Parse);

            Lenght = Array1.Length > Array2.Length ? Array1.Length : Array2.Length;
           
        }
        
    }
}