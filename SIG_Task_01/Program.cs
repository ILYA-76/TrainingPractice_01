using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SII_Task_01
{

    class Program
    {

        public const int Dimonds_cost = 100;  


        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество золота: ");
            int Gold = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Сколько кристаллов вы хотите обменять? Курс 1 кр. = {Dimonds_cost} золота");
            int Dimonds = Convert.ToInt32(Console.ReadLine());


            try                         
            {
                int calculation = Gold - Dimonds * Dimonds_cost;
                int[] arr = new int[Gold + 1];
                arr[calculation] = 1;
                Console.WriteLine($"Успешно. У вас {calculation} золота и {Dimonds} кристаллов.");

                Console.ReadKey();
            }
            catch (Exception e)           
            {
                Console.WriteLine($"У вас не достаточно золота \n{Gold} золота и 0 кристалл(ов).");

                int fail = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
            };
        }
    }


}
