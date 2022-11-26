using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class PassengerCar : Car
    {
        int _PassengerAmount;


        Dictionary<string, int> _RemontBook = new Dictionary<string, int>(); //создание словаря

        

        public PassengerCar(string mark, int power, int productionYear) : base(mark, power, productionYear)
        {
            //конструктор
        }
        
        public void AddToRemontBook(string ReplacePart, int ReplaceYear)
        {
            _RemontBook.Add(ReplacePart, ReplaceYear); //добавление части
        }
        public int GetYearByName(string ReplacePart)
        {
            
            return _RemontBook[ReplacePart]; //получение года по части
        }
        public void RemontBookPrint()
        {
            foreach(var item in _RemontBook)
            {
                Console.WriteLine($"Часть: {item.Key}  Год замены: {item.Value}"); //вывод
            }
        }
        public override string ToString()
        {
            return base.ToString() + " " + _PassengerAmount.ToString(); //переопределение ToString
        }
    }
}
