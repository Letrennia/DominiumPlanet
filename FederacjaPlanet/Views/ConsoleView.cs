using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Views
{
    public class ConsoleView
    {
        public int Show(string title, string[] options)
        {
            int selected = 0;
            ConsoleKey key;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(title);
            Console.ResetColor();

            Console.WriteLine("\nUse up and down to navigate and press Enter to select\n");

            int startTop = Console.CursorTop;

            for (int i = 0; i < options.Length; i++)
            {
                if (i == selected)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"> {options[i]}");
                    Console.ResetColor();
                }
                else
                Console.WriteLine($"> {options[i]}");

            }


            do
            {
                int previous = selected;
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    if (selected == 0) selected = options.Length - 1;
                    else selected--;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (selected == options.Length - 1) selected = 0;
                    else selected++;
                }


                Console.SetCursorPosition(0, startTop + previous);
                Console.ResetColor();
                Console.WriteLine($"> {options[previous]}");

                Console.SetCursorPosition(0, startTop + selected);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"> {options[selected]}");
                Console.ResetColor();


            } while (key != ConsoleKey.Enter);

            return selected;
        }
    }
}
