using CarClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Park
    {
        public static void Main(string[] args)
        {
            Car[] array = new Car[0];
            int n = 0;
            bool a = true;
            while (a)
            {
                Console.WriteLine("Меню: \n 1 - Добавить машину \n 2 - Поиск по базе \n 3 - Показать все машины в базе \n 4 - Выход из программы");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.D1:
                        Menu.AddCar(ref array, n);
                        n++;
                        break;
                    case ConsoleKey.D2:
                        Car.SearchCar(ref array);
                        break;
                    case ConsoleKey.D3:
                        Menu.PrintInfo(ref array);
                        break;
                    case ConsoleKey.D4:
                        a = false;
                        Console.WriteLine("Выход из программы");
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверную клавишу");
                        break;
                }
            }
        }
    }
}