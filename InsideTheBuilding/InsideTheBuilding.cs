using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InsideTheBuilding
{
    class InsideTheBuilding
    {

        static void Main()
        {
            int x = 0;

            int y = 0;

            int h = int.Parse(Console.ReadLine());

            string ab = "";
            for (int i = 0; i < 5; i++)
            {
                x = int.Parse(Console.ReadLine());

                y = int.Parse(Console.ReadLine());
                InFigure(x, y, h);
                
            }

           
            
        }

        public static void InFigure(int x, int y, int h)
        {
            int bottomX = 3 * h;
            int bottomY = h;
           
            int topLeftX = h;
            int topLeftRightY = h * 4;
            int topRightX = 2 * h;


            if (x<0 || y<0)
            {
                Console.WriteLine("outside");
                
            }else
            if (x <= bottomX && y <= bottomY)
            {
                Console.WriteLine("inside");
            }
            else if (x >= topLeftX && x <= topRightX && y <= topLeftRightY)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
