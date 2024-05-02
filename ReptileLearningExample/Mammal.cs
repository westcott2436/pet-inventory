using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReptileLearningExample
{
    public abstract class Mammal : Animal
    {
        public bool IsColdBlooded { get; set; }
        public Mammal(string name, int age, float weight) : base(name, age, weight)
        {
            IsColdBlooded = false;  
        }
    }
}
