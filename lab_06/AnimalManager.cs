using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_06
{

    internal class AnimalManager : Animal
    {
        public static List<Animal> animals = new List<Animal>();
        private object animal;

        //public AnimalManager(object animal)
        //{
        //    this.animal = animal;
        //}

        public static void addAnimal(object animal )
        {
            animals.Add((Animal)animal);
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
