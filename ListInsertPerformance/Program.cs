using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace ListInsertPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл в строку текста
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFile1.txt");
            string text = File.ReadAllText(path);

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] {' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            var list = new List<string>();

            // Запустим таймер
            var watch = Stopwatch.StartNew();

            // Добавляем все строки
            foreach(var row in words)
            {
                list.Add(row);
            }

            // Выведем результат
            Console.WriteLine($"Вставка в  List: {watch.Elapsed.TotalMilliseconds}  мс");

            Console.ReadLine();
        }
    }
}
