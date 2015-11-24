using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class PCCatalog
    {
        static void Main()
        {
            Components Motherboard = new Components();
            Motherboard.Name = "IntelALTServer";
         
            Motherboard.Price = 10.32m;
            Motherboard.Details = "No details";
 
            Components Processor = new Components("Pentium Dual-Core",14.32m, "All details");
 
            Components Ram = new Components("DDR2-400",10.43m,"All details");
 
            Components GraphicsCard = new Components("DB-15 VGA",10.32m, "No details");
 
            Components Hdd = new Components("256 SSD", 16.00m,"100 Terrabytes");
     
            List<Computer> computers = new List<Computer>
            {
                new Computer("ACCER", Motherboard, Processor, Ram, GraphicsCard, Hdd, 3200.43m),
                new Computer("APPLE", Motherboard, Processor, Ram, GraphicsCard, Hdd, 4433.65m),
                new Computer("LENOVO", Motherboard, Processor, Ram, GraphicsCard, Hdd,5800.65m),
                new Computer("ASUS", Motherboard, Processor, Ram, GraphicsCard, Hdd,11000.96m)
            };
            computers.Sort((x, y) => x.Price.CompareTo(y.Price));
            foreach (Computer pc in computers)
            {
                Console.WriteLine(pc);
            }
           
        }
    }
}
