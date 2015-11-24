using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class Components
    {
        private string name;
        private string details;
        private decimal price;

        public Components()
        {

        }

        public Components(string name, decimal price, string details)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(this.name))
                {
                    throw new ArgumentNullException("Enter a valid name for Code's sake!");

                }
                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Enter valid details information for Code's sake!");
                }
                this.details = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0.0m)
                {
                    throw new ArgumentNullException("Enter valid price value for Code's sake!");
                }
                this.price = value;
            }
        }
        public void ToString()
        {
            Console.WriteLine("Component name   : {0}", this.name ?? "[]");
            Console.WriteLine("Component details: {0}", this.details ?? "[]");
            Console.WriteLine("Component price  : {0:F2}", this.price);
        }
 
    }
}
