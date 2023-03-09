using CarClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Car
    {
        private string Mark, Model, Colour, Number, Time;
        private int Ind;
        public string mark
        {
            get => Mark;
        }
        public string model
        {
            get => Model;
        }
        public string color
        {
            get => Colour;
        }
        public string number
        {
            get => Number;
        }
        public string time
        {
            get => Time;
        }
        public int ind
        {
            get => Ind;
        }
        public Car(string mark = "No mark", string model = "Undefined", string colour = "No color", string number = "Undefined", string time = "Undefined", int ind = 0)
        {
            this.Mark = mark;
            this.Model = model;
            this.Colour = colour;
            this.Number = number;
            this.Time = time;
            this.Ind = ind;
        }
        public static void SearchCar(ref Car[] array)
        {
            Console.WriteLine("Введите информацию о машине которую хотите найти:");
            string findcar = Console.ReadLine();
            bool found = false;
            bool flag = false;
            int n = 0;
            foreach (var item in array)
            {
                if (item.Mark == findcar || item.Model == findcar || item.Colour == findcar || item.Number == findcar)
                {

                    Console.WriteLine($"1. марка: {item.Mark}\n2. модель: {item.Model}\n3. цвет: {item.Colour}\n4. номер: {item.Number}\n Это та машина которую вы искали?\n Y - да, любая другая клавиша - нет");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        found = true;
                        n = item.Ind;
                        break;
                    }

                    else
                    {
                        flag = true;
                        continue;
                    }
                }
            }

            Console.WriteLine("Удалить машину? Y/N");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Menu.DeleteCar(ref array, n);
                Console.WriteLine(" ");
            }

            if (found == false)
            {
                Console.WriteLine("\n Такой машины не найдено");
                Console.WriteLine(" ");
            }
            if (flag == true)
            {
                Console.WriteLine("\n Больше машин с таким описанием не найдено");
            }
        }
    }
}
