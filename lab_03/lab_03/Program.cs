using System;


namespace lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a national: ");
            string national = Console.ReadLine();

            switch (national)
            {
                case ("Ukranian"):
                    Ukranian.People();
                    break;
                case ("Italian"):
                    Italian.People();
                    break;
                default:
                    Console.WriteLine("Error\n \t Enter Italian or Ukranian\n");
                    break;
            }

            Console.ReadKey();
        }
    }
    abstract class Person
    {
        public static void PrintCountryName(string Country)
        {
            Console.Write("Country: " + Country);
        }

        public static void Speak(string lang)
        {
            switch (lang)
            {
                case ("Italian"):
                    Console.WriteLine("Language: Italian \n");
                    break;
                case ("Ukranian"):
                    Console.WriteLine("Language: Ukranian");
                    break;
                default:
                    Console.WriteLine("Wrong languge \n");
                    break;
            }
        }
    }
    internal class Ukranian : Person
    {
        public static string lang = "Ukranian";
        public static string Country = "Ukraine";

        public static void People()
        {
            Speak(lang);
            PrintCountryName(Country);
        }
    }
    internal class Italian : Person
    {
        public static string lang = "Italian";
        public static string Country = "Italy";

        public static void People()
        {
            Speak(lang);
            PrintCountryName(Country);
        }
    }

}