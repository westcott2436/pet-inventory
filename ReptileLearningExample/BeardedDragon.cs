using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReptileLearningExample
{
    internal class BeardedDragon : Reptile
    {
        public BeardedDragon(string name, int age, float weight) : base(name, age, weight) { }

        public override void Speak()
        {
            Console.WriteLine("Shzzzzzzz I'm a damn snake!");
        }
    }
}
