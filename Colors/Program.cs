using System;
using System.IO;

namespace horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            string userSign = Console.ReadLine(); 

            Console.WriteLine(GetColors(userSign));
            
        }

        

        public static string[] ReadColors()
        {

            string filePath = @"C:\Users\opilane\samples\personality";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;

        }

        public static string GetColors(string userInput)
        {
            string[] Colors = ReadColors();
            string todayColors = "";

            foreach (string element in Colors)
            {
                if (element.Contains(userInput))
                {
                    todayColors = element;

                }
            }
            return todayColors;
        }



    }
}
