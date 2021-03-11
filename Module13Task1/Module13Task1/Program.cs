using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Module13Task1
{
    class Program
    {

        static void Main(string[] args)
        {
           
            // читаем весь файл в строку 
            string text = File.ReadAllText(@"C:\Users\alena\Desktop\Text1.txt");
            // разбиваем в массив, используя пробел в качестве разделителя
            var words = text.Split(" ");

            ListInsertPerfomance(words);
            LinkedListInsertPerfomance(words);

        }

        static void ListInsertPerfomance(string[] words)
        {

            var listInsert = new List<string>();

            // Запустим таймер
            var watchTwo = Stopwatch.StartNew();

            // Выполним вставку
            listInsert.AddRange(words);

            // Выведем результат
            Console.WriteLine($"Вставка в List: {watchTwo.Elapsed.TotalMilliseconds}  мс");

        }

        static void LinkedListInsertPerfomance(string[] words)
        {

            var linkedListInsert = new LinkedList<string>();

            // Запустим таймер
            var watchTwo = Stopwatch.StartNew();


            // Выполним вставку
            foreach (string w in words)
                linkedListInsert.AddFirst(w);

            // Выведем результат
            Console.WriteLine($"Вставка в LinkedList: {watchTwo.Elapsed.TotalMilliseconds}  мс");

        }
    }
}
