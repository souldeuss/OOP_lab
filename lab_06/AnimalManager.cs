using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_06
{

    internal class AnimalManager : Animal
    {
        public static List<AnimalManager> animals = new List<AnimalManager>();

        public static void addAnimal(object animal )
        {
            animals.Add(AnimalManager animal = new AnimalManager());
            foreach (AnimalManager obj in animals)
            {
                Console.WriteLine($"Add {obj}");
            }
        }

        public static void playSounds()
        {
            foreach (AnimalManager unit in animals)
            {
                unit.Sound;
            }
        }
    }
}
