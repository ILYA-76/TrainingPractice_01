using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SII_Task_03
{
    class Program
    {

        public static int t = 2; // Кол-во попыток (Взято 2, так как Первая попытка была использована)
        static void Main(string[] args)
        {

            string I14 = "I14"; // Пароль



            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите пароль: ");
                string password = Console.ReadLine();
                if (password == I14)
                {

                    goto Finish_good;

                }

                else if (t == 0)
                {
                    goto Finish_bad;
                }
                else
                {

                    Console.WriteLine($"Пароль неверен, кол-во попыток: {t}");
                    t--;
                }



            }

        Finish_good:
            Console.WriteLine();
            Console.WriteLine("Пароль верен, Добро пожаловать  \n");
            Console.ReadKey();
            Environment.Exit(0);

        Finish_bad:
            Console.WriteLine();
            Console.WriteLine("Вы привысили количесвто попыток  \n");
            Console.ReadKey();
            Environment.Exit(0);



        }
    }
}