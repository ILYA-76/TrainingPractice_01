using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SII_Task_04
{

    class Progaram
    {
        static void Main(string[] args)
        {
            Random HpP = new Random();
            Random HpB = new Random();


            int HpPlayer = HpP.Next(250, 500); // Случайное здоровье Игрока
            int HpBoss = HpB.Next(400, 900);  // Случайное здоровье Босса
            int UltimateDamage = 0; // Если равно 3, срабатывает тень
            bool Attack = false;


            Random bsd = new Random(); // Урона Босса
            Random hlp = new Random(); // Прибавления здоровья
            Random kam = new Random(); // Пропуска хода Босса от Валуна


            Console.WriteLine("Вы тенеаой маг. Сейчас вам предстоит одолеть Босса.\n");
            Console.WriteLine("Босс наносит урон в диапазоне от 10 до 80 единиц \n");
            Console.WriteLine("Ваша атака проходит после атаки Босса\n");


            do
            {
            chooseAgain:
                Console.WriteLine($"Ваше здровье: {HpPlayer}");
                Console.WriteLine($"Здоровье Босса: {HpBoss}\n");
                Console.Write("Выберите заклинание на этот ход:\n" +


                "1.Огненная шар (50 урона) \n" +
                "2.Струя воды(С 50% шансом выбивает Босса из рановесия, при срабатывание получаете лечение (100),если здоровье ниже 250)\n" +
                "3.Летящий валун(100 урона )(С 50% шансом оглушает босса на 1 ход)\n" +
                "4.Вы можете призвать Тень которая нанесет 100 урона, для этого вам нужно 3 раза повторить это заклинание\n" +
                "5.Приказывает Тень атаковать врага(100)  \n");


                int spell = 0;


                try { spell = Convert.ToInt32(Console.ReadLine()); } 
                catch
                {
                    Console.WriteLine("Вы ввели не тот тип данных.");
                    goto chooseAgain;
                }
                Console.Clear();


                int BossDamage = bsd.Next(10, 80); // Получение случайного числа (Урона Босса)
                int chanseHelp = hlp.Next(0, 2);  // 50% шанс на срабатывание заклинания 
                int stun = kam.Next(0, 2); // 50% шанс на пропуск хода Босса


                switch (spell) // Выборка 
                {
                    case (1):


                        HpBoss -= 50;
                        break;


                    case (2):


                        if (chanseHelp == 1 && Attack == true)
                        {
                            Console.WriteLine("Вы выбили Босса из равновессия");
                            BossDamage = 0;
                            if (HpPlayer < 250) 
                            {
                                HpPlayer += 100;
                            }


                        }

                        break;


                    case (3):


                        if (stun == 1)
                        {
                            Console.WriteLine("Босс оглушен\n");
                            BossDamage = 0;
                        }
                        HpBoss -= 100;
                        break;


                    case (4): // при 3 вызывается Тень


                        UltimateDamage = UltimateDamage + 1;


                        if (UltimateDamage > 3)
                        {
                            Console.WriteLine("Тень уже призвана, вы пропускаете ход!");

                        }
                        if (UltimateDamage == 3)
                        {
                            Console.WriteLine("Вы призвали Тень и она нанесла Боссу 100 едениц урона!\n");
                            HpBoss -= 100;


                        }
                        break;


                    case (5):


                        HpBoss -= 100;

                        break;

                    default:
                        Console.WriteLine("Вы ничего не скастовали! ");
                        break;


                }


                HpPlayer -= BossDamage;
                Attack = true;




            } while (HpBoss > 0 && HpPlayer > 0); // окончание битвы 
            if (HpPlayer <= 0)
            {
                Console.WriteLine("Вы погибли... ");
                Console.ReadKey();

            }
            else if (HpBoss <= 0)
            {
                Console.WriteLine("Вы победили! ");
                Console.ReadKey();

            }
        }

    }
}
