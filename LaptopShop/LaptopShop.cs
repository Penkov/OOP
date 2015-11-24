using System;

class LaptopShop
{
    static void Main()
    {
        Laptop laptopInfo = new Laptop
        {
            model = Console.ReadLine(),
            manufacturer = Console.ReadLine(),
            processor = Console.ReadLine(),
            ram = int.Parse(Console.ReadLine()),
            graphicCard = Console.ReadLine(),
            hdd = Console.ReadLine(),
            screen = Console.ReadLine(),
            batteryInfo = new _Battery
            {
                battery = Console.ReadLine(),
                batteryLife = double.Parse(Console.ReadLine())
            },
            price = decimal.Parse(Console.ReadLine()),

        };

        Console.WriteLine(laptopInfo);
    }
}
