using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SII_Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            //ввод
            int[,] maze = new int[,]
            {
{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
{1,0,1,1,0,1,0,0,0,1,0,0,0,0,0,1,1,0,1,0,0,0,1,0,0,0,0,1,0,0,0,0,1},
{1,0,0,0,0,1,0,1,0,1,0,1,1,1,0,0,0,0,1,0,1,0,1,0,1,1,0,0,0,1,1,0,1},
{1,1,1,1,0,1,0,1,0,1,0,1,1,1,0,1,1,0,1,0,1,0,1,0,1,1,0,1,0,1,1,0,1},
{1,0,0,0,0,1,0,1,0,1,0,1,1,0,0,0,0,0,1,0,1,0,1,0,1,1,0,1,0,1,1,0,1},
{1,1,0,1,1,1,0,1,0,1,0,1,1,0,1,0,1,1,1,0,1,0,1,0,1,1,0,0,0,0,1,0,1},
{1,0,0,0,0,0,0,1,0,1,0,1,1,1,1,0,0,0,0,0,1,0,1,0,1,1,1,1,1,0,1,0,1},
{1,1,1,1,1,1,1,1,0,0,0,1,1,0,1,1,1,1,1,1,1,0,0,0,1,0,0,0,1,0,0,0,1},
{1,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,1,1,1,0,1,0,1,1,1},
{1,1,1,1,0,1,0,1,0,1,0,1,1,0,1,1,1,1,1,1,0,1,1,0,0,0,0,0,1,0,0,1,1},
{1,0,0,1,0,1,0,1,0,1,0,1,1,1,1,1,1,0,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1},
{1,0,1,1,0,1,0,1,0,1,0,0,0,1,0,1,1,0,1,0,0,0,1,0,0,0,0,1,0,0,0,1,1},
{1,0,0,0,0,1,0,1,0,1,0,1,1,1,0,0,0,0,1,0,1,0,1,0,1,1,0,1,0,1,1,1,1},
{1,1,1,1,0,1,0,1,0,1,0,1,0,1,1,1,1,0,1,0,1,0,1,0,1,1,0,1,0,0,0,0,1},
{1,0,0,0,0,1,0,1,0,1,0,1,0,1,0,0,0,0,1,0,1,0,1,0,1,1,0,1,1,1,1,0,1},
{1,1,0,1,1,1,0,1,0,1,0,1,0,1,1,0,1,1,1,0,1,0,1,0,1,1,0,0,0,0,1,0,1},
{1,1,0,0,0,0,0,1,0,1,0,1,0,1,1,0,0,0,0,0,1,0,1,0,1,1,1,1,1,0,1,1,1},
{1,1,1,1,1,1,1,1,0,0,0,1,0,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,1,0,1,1,1},
{1,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,1,1,1,1,0,0,1,0,1,1,1},
{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1}
            };
            //координаты игрока
            int x = 1, y = 1;
            try
            {
                while (true)
                {
                    //рисуем лабиринт
                    Console.Clear();
                    for (int i = 0; i < maze.GetLength(0); i++)
                    {
                        for (int j = 0; j < maze.GetLength(1); j++)
                        {
                            if (maze[i, j] == 0) Console.Write(".");
                            if (maze[i, j] == 1) Console.Write("▒");

                        }
                        Console.WriteLine();
                    }
                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("■");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;

                    // обработка ввода
                    ConsoleKeyInfo ki = Console.ReadKey();
                    if (ki.Key == ConsoleKey.Escape) break;
                    if (ki.Key == ConsoleKey.LeftArrow && maze[y, x - 1] == 0) x--;
                    if (ki.Key == ConsoleKey.RightArrow && maze[y, x + 1] == 0) x++;
                    if (ki.Key == ConsoleKey.UpArrow && maze[y - 1, x] == 0) y--;
                    if (ki.Key == ConsoleKey.DownArrow && maze[y + 1, x] == 0) y++;
                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine("End");
                Console.ReadKey();
            }

        }
    }
}