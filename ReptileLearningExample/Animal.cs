using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReptileLearningExample
{
   
    public abstract class Animal
    {
        public Color Color { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public Animal(string name, int age, float weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
    }
}
