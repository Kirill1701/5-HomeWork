using System;

namespace _5._5._2_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            static void ReversWords(string inputText)
            {
                Console.WriteLine(inputText);

                string[] words = inputText.Split(' ');

                Array.Reverse(words);

                foreach (string word in words)
                {
                    Console.WriteLine($"<{word}>");
                }
            }
            ReversWords("Сегодня на улице идет дождь и солнце спряталось за тучи.");


        }
    }
}
