using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class Car
    {
        protected string? _mark;
        protected int _power;
        protected int _ProductionYear;
        public Car(string mark, int power, int productionYear)
        {
            Console.WriteLine("Создание объекта Car");
            _mark = mark;
            _power = power;
            _ProductionYear = productionYear;

        }
        public override string ToString()
        {
            return _mark + " " + _power + " " + _ProductionYear;
        }
    }
}
