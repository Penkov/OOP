using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal
    {
        private string name;
        private int age;
        private Genders gender;

        public Animal(string name, int age, Genders gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name can not be an empty string.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age can not be a negative number.");
                }

                this.age = value;
            }
        }

        public Genders Gender
        {
            get { return this.gender; }
            protected set { this.gender = value; }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return String.Format("My name is {0}, I'm {1} years old, I'm {2} and I can {3}",
                 this.name, this.age, this.gender, this.ProduceSound());
        }
    }
}
