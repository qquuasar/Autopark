using System;

namespace Autopark;

class Program
{
    static void Main()
    {

        Autopark Zavod = new Autopark("Zavod");
        PassengerCar Audi = new PassengerCar("Audi", 300, 2022);
        Truck Kamaz =  new Truck("MAN", 700, 2005);
        
        
        
        Console.WriteLine("---");
        Console.WriteLine( Zavod.ToString());
        
        
    }
}