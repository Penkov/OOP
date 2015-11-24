using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            : base(name, age, Genders.Male)
        {
        }

        // implemetn the ISound interface
        public override string ProduceSound()
        {
            return "phhh";
        }

        // define a Piss() method
        public void Piss()
        {
            Console.WriteLine("I'll piss all over your carpet");
        }

        // override the ToString() method
        public override string ToString()
        {
            return String.Format("I'm a tomcat ") + base.ToString();
        }
    }
}
