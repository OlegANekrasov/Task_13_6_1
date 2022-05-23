using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace LinkedListInsertPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл в строку текста
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFile1.txt");
            string text = File.ReadAllText(path);

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            var linkedList = new LinkedList<string>();

            // Запустим таймер
            var watchTwo = Stopwatch.StartNew();

            // Добавляем все строки
            foreach (var row in words)
            {
                linkedList.AddLast(row);
            }

            // Выведем результат
            Console.WriteLine($"Вставка в  List: {watchTwo.Elapsed.TotalMilliseconds}  мс");

            Console.ReadLine();
        }
    }
}
