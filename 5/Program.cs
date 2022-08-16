using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            static void SplitOutput(string Text)
            {
                Console.WriteLine(Text);

                string[] words = Text.Split(' ');

                foreach (string word in words)
                {
                    Console.WriteLine($"<{word}>");
                }
            }

            SplitOutput("Сегодня на улице идет дождь и солнце спряталось за тучи.");

        }
    }
}
