using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component
{
    class media
    {
        public static void tulis(int col, int row, string text, ConsoleColor warna = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = warna;
            Console.BackgroundColor = bg;
            Console.WriteLine(text);
        }
        public static void block(int col1, int col2, int row1, int row2, ConsoleColor warna = ConsoleColor.Gray)
        {
            for (int i = 0; i <= col2 - col1; i++)
            {
                for (int j = 0; j <= row2 - row1; j++)
                {
                    media.tulis(col1 + i, row1 + j, " ", warna, warna);
                }
            }
        }

        public static string input(int col, int row, ConsoleColor warna = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            Console.ForegroundColor = warna;
            Console.BackgroundColor = bg;
            Console.SetCursorPosition(col, row);
            string data = Console.ReadLine();
            return data;
        }
    }
}
