using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReptileLearningExample
{
    public class Mouse : Mammal
    {
        public int TailLength { get; set; }
        public Mouse(string name, int age, float weight, int tail ) : base(name, age, weight)
        {
            TailLength = tail;
        }
    }
}
