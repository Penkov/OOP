using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book podigoto = new Book("Pod Igot", "Ivan Vazav", 35.0m);

            GoldenEditionBook perfe = new GoldenEditionBook("Perfe", "perfection", 5.0m);

            Console.WriteLine(podigoto.ToString());
            Console.WriteLine(perfe.ToString());
        }
    }
}
