using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SII_Task_06
{
    class Program
    {


        static void Main(string[] args)
        {


            string[][] fio = new string[3][]; 
            fio[0] = new string[100];//Фамилия
            fio[1] = new string[100];//Имена
            fio[2] = new string[100];//Отчество


            string[] dolzh = new string[100];// Должность
            int i = 0;//Количество записей
            bool isNeeded = true; // Проверка для выхода из массива


            do
            {


                Console.Write("Отдел кадров: " +
                           "\n  1. добавить досье " +
                           "\n  2. вывести все досье" +
                           "\n  3. удалить досье" +
                           "\n  4. поиск по фамилии" +
                           "\n  5. выход из программы \n \n");
                Console.Write("Выберите пункт меню: ");


                int function;
                try { function = Convert.ToInt32(Console.ReadLine()); } 
                catch { function = 0; }
                Console.Clear();


                switch (function)
                {


                    case 1:


                        Console.Write("Введите Фамилию: ");
                        fio[0][i] = Console.ReadLine();
                        Console.Write("Введите Имя: ");
                        fio[1][i] = Console.ReadLine();
                        Console.Write("Введите Отчество: ");
                        fio[2][i] = Console.ReadLine();

                        Console.Write("Введите должность: "); // Вводим данные о человеке
                        dolzh[i] = Console.ReadLine();
                        i++; // Увеличиваем число записей на 1
                        Console.Write("Данные занесены усспешно. Нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 2:


                        if (i != 0)
                        {

                            Console.Clear();
                            Console.WriteLine("Вывод всех досье: \n");
                            for (int j = 0; j <= i - 1; j++)
                            {
                                Console.WriteLine($"{j}. {fio[0][j]} {fio[1][j]} {fio[2][j]} - {dolzh[j]}"); // Выводим все данные
                            }
                            Console.Write("\n Нажмите любую клавишу...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else
                        {

                            Console.Write("Не найдено ни одной записи. Нажмите любую кнопку для продолжения!");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;


                    case 3:


                        Console.Write("Введите номер досье для удаления: ");
                        int choice;
                    again:
                        try { choice = Convert.ToInt32(Console.ReadLine()); }
                        catch { goto again; }

                        bool isFounded = false; 
                        if (choice <= i && choice > 0) 
                        {

                            for (int j = 0; j <= i; j++)
                            {

                                if (j == choice || isFounded)
                                {

                                    if (j != i - 1) 
                                    {

                                        fio[0][j] = fio[0][j + 1];
                                        fio[1][j] = fio[1][j + 1];
                                        fio[2][j] = fio[2][j + 1];
                                        dolzh[j] = dolzh[j + 1];
                                        isFounded = true;

                                    }
                                    else
                                    {

                                        fio[0][j] = "";
                                        fio[1][j] = "";
                                        fio[2][j] = "";
                                        dolzh[j] = "";

                                    }
                                }
                            }
                            i--; 
                            Console.WriteLine("Досье удалено успешно. Нажмите любую клавишу...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("Досье с таким номером не существует. Нажмите любую клавишу...");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;


                    case 4:


                        Console.Write("Введите фамилию для поиска: ");
                        string surname = Console.ReadLine(); // Ввод нужной фамилии
                        bool isAtLeastOne = false; // Проверка 


                        for (int j = 0; j <= i; j++)
                        {


                            if (surname == fio[0][j])
                            {

                                isAtLeastOne = true;
                                Console.WriteLine($"{j}. {fio[0][j]} {fio[1][j]} {fio[2][j]} : {dolzh[j]}");

                            }


                        }
                        if (!isAtLeastOne)
                        {

                            Console.WriteLine("Сотрудников с такой фамилией нет");


                        }

                        Console.WriteLine("\n Нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();

                        break;


                    case 5:


                        isNeeded = false;
                        break;
                    default:
                        Console.WriteLine("Нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }


            } while (isNeeded);
        }
    }
}
