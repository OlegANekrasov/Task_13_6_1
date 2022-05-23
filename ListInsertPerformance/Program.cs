using System;
using System.IO;

namespace ListInsertPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл с рабочего стола в строку текста
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"TextFile1.txt");
            string text = File.ReadAllText(path);
            //string text = File.ReadAllText(@"E:\C#\Skillfactory\Учеба C#\Проекты\13\cdev_Text.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] {'\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // выводим количество
            Console.WriteLine(words.Length);

            Console.ReadLine();
        }
    }
}
