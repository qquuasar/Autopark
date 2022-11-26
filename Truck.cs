using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class Truck : Car
    {
        public int MaxLoadCapacity;
        public string? DriversLastAndFirstName;
        Dictionary<string, int> CurrentLoad = new Dictionary<string, int>(); //создание словаря
        public Truck(string mark, int power, int productionYear) : base(mark, power, productionYear)
        {
        }
        public void DriverChange(string NewDriversLastAndFirstName)
        {
            DriversLastAndFirstName = NewDriversLastAndFirstName;
        }
        public void LoadAdd(string LoadName, int LoadWeight)
        {
            CurrentLoad.Add(LoadName, LoadWeight);
        }
        public void LoadRemove(string LoadName)
        {
            CurrentLoad.Remove(LoadName);
        }
        public void CurrentLoadPrint()
        {
            foreach (var item in CurrentLoad)
            {
                Console.WriteLine($"Часть: {item.Key}  Год замены: {item.Value}"); //вывод
            }
        }
        public override string ToString()
        {
            return base.ToString() + " " + MaxLoadCapacity + " " + DriversLastAndFirstName;
        }
    }
}
