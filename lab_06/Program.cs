using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMPLib;

namespace lab_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Console.TreatControlCAsInput = true;
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = Console.ReadKey();
               
                Console.WriteLine("Add animal (cat/dog)");

                string animal = Console.ReadLine();

                if (animal.ToLower() == "cat")
                {
                    var Cat = new Cat();
                    AnimalManager.addAnimal(Cat);
                }
                else if (animal.ToLower() == "dog")
                {
                    var Dog = new Dog();
                    AnimalManager.addAnimal(Dog);
                }
                AnimalManager.playSounds();
                
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
