using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class Autopark
    {
        string _AutoparkName;
        
     
        List<object> Examples = new List<object> {};
        public Autopark(string AutoparkName)
        {
            Console.WriteLine("Создание объекта Autopark");
            _AutoparkName = AutoparkName;           //конструктор
        }
        
        
        public override string ToString()
        {
            

            return _AutoparkName + " " + base.ToString() + " " + PassengerCar.ToString() + " " + Truck.ToString(); //не особо понял как делать в этом моменте
        }
    }
}
