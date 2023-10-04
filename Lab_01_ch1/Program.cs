using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_ch1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1();

            //Task2();

            Task3();

            Console.ReadKey();
        }

        static void Task1()
        {
            Console.WriteLine("Enter the name of group");
            string usrname = Console.ReadLine();
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(usrname + " " + dateTime);
        }
        static void Task2()
        {
            Console.Write("Variant(1-9):");
            int Var = Convert.ToInt32(Console.ReadLine());

            Console.Write("a:");
            double UsrVarA = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("b:");
            double UsrVarB = Convert.ToDouble(Console.ReadLine());

            switch (Var)
            {
                case 1:
                    Console.WriteLine($"1. {UsrVarA}^1/2 = {Math.Pow(UsrVarA, 0.5)}");
                    break;
                case 2:
                    Console.WriteLine($"2. Exp({UsrVarA}) = {Math.Exp(UsrVarA)}");
                    break;
                case 3:
                    Console.WriteLine($"3. Lg {UsrVarA} = {Math.Log10(UsrVarA)}");
                    break;
                case 4:
                    Console.WriteLine($"4. Sin({UsrVarA}) = {(180 / Math.PI) * Math.Sin(UsrVarA)}°");
                    break;
                case 5:
                    Console.WriteLine($"5. Cos({UsrVarA}) = {(180 / Math.PI) * Math.Cos(UsrVarA)}°");
                    break;
                case 6:
                    Console.WriteLine($"6. Tg({UsrVarA}) = {(180 / Math.PI) * Math.Tan(UsrVarA)}°");
                    break;
                case 7:
                    Console.WriteLine($"7. Ctg({UsrVarA}) = {(180 / Math.PI) / Math.Tan(UsrVarA)}°");
                    break;
                case 8:
                    Console.WriteLine($"8. {UsrVarA}^{UsrVarB} = {Math.Pow(UsrVarA, UsrVarB)}");
                    break;
                case 9:
                    Console.WriteLine($"9. ln({UsrVarA}) = {Math.Log(UsrVarA)}");
                    break;
                default:
                    Console.WriteLine("Error");
                    Task2();
                    break;
            }
        }
        static void Task3()
        {
            Console.WriteLine("Enter degrees :");

            double Celsius = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i <= Celsius; i++)
            {
                double Fahrenheit = 9 * i / 5 + 32;
                Console.WriteLine($"|{i}. Fahrenheit : {Fahrenheit}|");
                Console.WriteLine($"___________________");
            }
        }
    }
}
