using System;
using System.Collections.Generic;
using ConsoleTables;

namespace lab_02
{
    internal class Plane
    {
        //Ініціалізуємо змінні "get" і "set" дозволяють забезпечити контроль над доступом до полів класу і зміних
        public int Num { get; set; }

        public string Name { get; set; }

        public int Flight { get; set; }

        public double Cost { get; set; }

        public int Passengers { get; set; }

        public double AvgCost { get; set; }

        //Cтворюємо сипсок з об'єктів

        public static List<Plane> PlaneList = new List<Plane>();

        //Конструктор який використовується для створення нових об'єктів
        public Plane(int num, string name, int flight, double cost, int passengers, double avgCost)
        {
            Num = num;
            Name = name;
            Flight = flight;
            Cost = cost;
            Passengers = passengers;
            AvgCost = avgCost;
        }
        //Створюємо нові об'єкти на основі введених даних
        public static void setValues(int Num, string Name, int Flight, double Cost, int Passengers, double AvgCost)
        {
            PlaneList.Add(new Plane(Num, Name, Flight, Cost, Passengers, AvgCost));
        }
        //Запит даних у користувача
        public static void UsrInput(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int num = i + 1;
                Console.Clear();
                Print($"Є: {i} / {n}\n");

                Print("Тип лiтака: ");
                string name = Console.ReadLine();

                Print("Рейс: ");
                int flight = Convert.ToInt32(Console.ReadLine());

                Print("Витрати на рейс, грн.: ");
                double cost = Convert.ToDouble(Console.ReadLine());

                Print("Кiлькiсть пасажирiв: ");
                int passengers = Convert.ToInt32(Console.ReadLine());
                //Розрахунок середньої вартості та округлення до сотих
                double avgCost = Math.Round(cost / passengers,2);

                Console.Clear();
                //Передаємо значення в об'єкт
                setValues(num, name, flight, cost, passengers, avgCost);
            }
        }
        //Остаточне створення таблиці
        public static void TableOfPlane(int i)
        {
            //Ініціалізація таблиці
            var table = new ConsoleTable("#", "Тип лiтака", "Рейс", "Витрати на рейс, грн.", "Кiлькiсть пасажирiв", "Середня вартiсть перевезення, грн.");

            //Цикл в якому створюються нові рядки
            foreach (var plane in PlaneList)
            {
                table.AddRow(plane.Num, plane.Name, plane.Flight, plane.Cost, plane.Passengers, plane.AvgCost);
            }
            //Масив сум введених та обчислених даних
            double[] sum = {0, 0, 0, 0}; 
            foreach (var plane in PlaneList)
            {
                sum[0] += plane.Flight;
                sum[1] += plane.Cost;
                sum[2] += plane.Passengers;
                sum[3] += plane.AvgCost;
            }
            //Додавання рядка сум
            table.AddRow("","Всього:",sum[0], sum[1], sum[2], sum[3]);
            //Форматування таблиці  
            table.Write(Format.Alternative);
        }

        public static void Print(string word)
        {
            Console.Write(word);
        }
    }
}
    
