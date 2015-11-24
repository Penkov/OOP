using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class Computer
    {
        public Computer()
        {

        }
        private string name;
        private Components motherboard;
        private Components processor;
        private Components ram;
        private Components graphicsCard;
        private Components hdd;
        private decimal price;

        public Computer(string name, Components motherboard, Components processor,
               Components ram, Components graphicsCard, Components hdd, decimal price)
        {
            this.Name = name;
            this.Motherboard = motherboard;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Price = price;
        }
        public string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Enter a valid Computer name");

                }
                this.Name = value;
            }
        }

        public Components Motherboard { get; set; }
        public Components Processor { get; set; }
        public Components GraphicsCard { get; set; }
        public Components Hdd { get; set; }
        public Components RAM { get; set; }

        public decimal Price
        {

            get
            {
                return this.Price;
            }
            set
            {
                decimal CalculatePrice = 0.0m;
                if (Motherboard != null)
                {
                    CalculatePrice = CalculatePrice + Motherboard.Price;
                }

                if (Processor != null)
                {
                    CalculatePrice = CalculatePrice + Processor.Price;
                }
                if (GraphicsCard != null)
                {
                    CalculatePrice = CalculatePrice + GraphicsCard.Price;
                }
                if (Hdd != null)
                {
                    CalculatePrice = CalculatePrice + Hdd.Price;
                }
                if (RAM != null)
                {
                    CalculatePrice = CalculatePrice + RAM.Price;
                }

                this.Price = CalculatePrice;
            }
        }

        public void ToString()
        {
            string console_output = "Computer:"; ;
            console_output = console_output + "\n   Name: " + this.Name + "\n";

            if (this.Motherboard != null)
            {
                console_output += "\n   Name: " + this.Motherboard + "\n";
            }
            if (this.Processor != null)
            {
                console_output += "\n   Name: " + this.Motherboard + "\n";
            }

            if (this.GraphicsCard != null)
            {
                console_output += "\n   Name: " + this.GraphicsCard + "\n";
            }
            if (this.Hdd != null)
            {
                console_output += "\n   Name: " + this.Hdd + "\n";
            }
            if (this.RAM != null)
            {
                console_output += "\n   Name: " + this.RAM + "\n";
            }
            Console.WriteLine(console_output);
        }
    }
}
