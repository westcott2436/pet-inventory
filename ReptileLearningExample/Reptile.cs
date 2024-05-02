using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReptileLearningExample
{
    public abstract class Reptile : Animal
    {
        public bool IsColdBlooded => true;
        protected Reptile(string name, int age, float weight) :base(name, age, weight) {
            
        }

        public virtual void Speak() { }
    }
}
