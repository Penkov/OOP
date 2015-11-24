using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;

        public string Title 
        {
            get 
            {
                return this.title;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Title cannot is null");
                }

                this.title = value;
            } 
        }
        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Author cannot is null");
                }

                this.author = value;
            }
        }
        public virtual decimal Price 
        { 
            get 
            {
                return this.price;
            } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot is negativ");
                }

                this.price = value;
            }
        }
        public Book(string title, string author, decimal price)
        {
            this.Price = price;
            this.Title = title;
            this.author = author;
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
            output.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
            output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
            output.AppendFormat("-Price: {0:F2}{1}", this.Price, Environment.NewLine);
            return output.ToString();
        }
    }
}
