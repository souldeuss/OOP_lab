using System;

namespace lab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввід кількості рейсів
            Print("Введiть кiлькiсть рейсiв: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //Використання методу який запитує данні у користувача
            Plane.UsrInput(n);

            //Очищує консоль
            Console.Clear();

            //Виводить таблицю згідно кількості рейсів
            Plane.TableOfPlane(n);

            Console.ReadKey();
        }
        
        //Метод замість Console.Write()
        public static void Print(string word)
        {
            Console.Write(word);
        }
    }
}
