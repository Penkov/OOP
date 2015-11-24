using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Dog : Animal,ISound
    {
        public Dog(string name, int age, Genders gender)
            : base(name, age, gender)
        {

        }

        // sound dog
        public override string ProduceSound()
        {
            return "bark";
        }
        // define a method for fetching a stick
        public void FetchStick()
        {
            Console.WriteLine("Throw me a stick and I'll fetch it for you.");
        }

        //print
        public override string ToString()
        {
            return String.Format("I'm a dog ") + base.ToString();
        }
    }
}
