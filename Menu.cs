using Parking;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    public class Menu
    {
        public static void AddCar(ref Car[] array, int n)
        {
            Console.WriteLine("Введите информацию о машине");
            Console.WriteLine("Марка:");
            string inMark = Console.ReadLine();
            Console.WriteLine("Модель:");
            string inModel = Console.ReadLine();
            Console.WriteLine("Цвет:");
            string inColor = Console.ReadLine();
            Console.WriteLine("Номер:");
            string inNumber = Console.ReadLine();
            Console.WriteLine("Время прибытия");
            string inTime = Console.ReadLine();

            Car car = new Car(inMark, inModel, inColor, inNumber, inTime, n);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = car;
            //return array;
        }
        public static void PrintInfo(ref Car[] array)
        {
            int i = 1;
            foreach (Car item in array)
            {
                Console.WriteLine("Машина номер " + i);
                Console.WriteLine($"1. Марка: {item.mark}\n2. Модель: {item.model}\n3. Цвет: {item.color}\n4. Номер: {item.number}\n5. Время прибытия: {item.time}");
                i++;
            }
        }
        public static void DeleteCar(ref Car[] array, int n)
        {
            var b = new Car[array.Length - 1]; // Предположим, что массивы целочисленные
            Array.Copy(array, 0, b, 0, n);
            Array.Copy(array, n + 1, b, n, array.Length - n - 1);
            array = b;
        }
    }
}