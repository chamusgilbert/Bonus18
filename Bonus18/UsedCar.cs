using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class UsedCar:Car
    {
        public double miles;

        public UsedCar(string make, string model, int year, double price, double miles) : base(make, model, year, price)
        {
            this.miles = miles;
            this.carInfo = CarInfo(make, model, year, price, miles);
        }
        public static string CarInfo(string make, string model, int year, double price, double miles)
        {
            return string.Format("{0,10} {1,10} {2,4} {3,14} {4,15}", make, model, year, price, miles);
        }
    }
}
