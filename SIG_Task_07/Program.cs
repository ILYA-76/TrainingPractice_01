using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SII_Tusk_07
{
    class Program
    {
        public static void Shuffle<T>(T[] a)
        {
            Random rand = new Random();

            for (int i = a.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = a[j];
                a[j] = a[i];
                a[i] = tmp;
            }

        }
        private static void Main(string[] args)
        {
        k:
            try
            {
                Console.WriteLine("Сколько случайных числе будет в массиве?");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] m = new int[n];
                Random r = new Random();
                for (int i = 0; i < m.Length; i++)
                {
                    m[i] = r.Next(-100, 101);
                }
                Console.Write("Ваши числа до изменения:  ");
                Console.WriteLine(string.Join(" ", m));
                Shuffle(m);
                Console.Write("Ваши числа после изменения: ");
                Console.WriteLine(string.Join(" ", m));
                Console.ReadKey();


            }

            catch (Exception e)
            {
                Console.WriteLine("Вы ввели не тот тип данных!" +
                    "\nПопробуйте еще раз (Программа принимает лишь тип данных в ввиде INT)\n");

                goto k;
            }

        }

    }
}