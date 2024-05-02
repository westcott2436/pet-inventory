using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReptileLearningExample
{
    public class BallPython : Reptile
    {
        public BallPython(string name, int age, float weight) : base(name, age, weight) {
        }


        public override void Speak()
        {
            Console.WriteLine("I'm a fucking Ball python Raaaaar!");
        }
    }
}
