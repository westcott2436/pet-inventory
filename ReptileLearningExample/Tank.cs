using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReptileLearningExample
{
    public class Tank
    {
        public int Capacity { get; set; }
        public int Size { get; set; }
        List<Animal> tankInhabitants = new List<Animal>();
        /// <summary>
        /// This is the concept of a Fish Tank it takes capcity in terms of Number of Reptiles it can support, and size in terms of gallons.
        /// </summary>
        /// <param name="capacity"></param>
        /// <param name="size"></param>
        public Tank(int capacity, int size)
        {
            Capacity = capacity;
            Size = size;
        }

        public void AddInhabitant(Animal inhabitant)
        {
            tankInhabitants.Add(inhabitant);
        }

        public void ListInhabitants()
        {
           foreach(Animal inhabitant in tankInhabitants)
            {
                Console.WriteLine($"We found a {inhabitant.GetType().Name} and its name is {inhabitant.Name}!");
            }

        }

        public void Feed(Mouse mouse)
        {
            AddInhabitant(mouse);
            Console.WriteLine($"You just dropped {mouse.Name} into the tank!");
        }
    }
}
