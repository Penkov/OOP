using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Frog : Animal,ISound
    {
        public Frog(string name, int age, Genders gender)
            : base(name, age, gender)
        {
        }

        // implement the ISound interface
        public override string ProduceSound()
        {
            return "rrrebbet";
        }

        // define a method for jumping
        public void Jump()
        {
            Console.WriteLine("Now I'll jump on your head.");
        }

        // override the ToString() method
        public override string ToString()
        {
            return String.Format("I'm a frog ") + base.ToString();
        }
    }
}
