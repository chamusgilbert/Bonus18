using System;
namespace Bonus18

{
    class Car
    {
        public string make;
        public string model;
        public int year;
        public double price;
        public string carInfo;

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.carInfo = string.Format("{0,10}  {1,10}  {2,4}   {3,15}", make, model, year, price);
        }

        public static void Print(string info)
        {
            Console.WriteLine(info);
        }


    }
    class UsedCar : Car
    {

        public UsedCar(string make, string model, int year, double price)
            : base(make, model, year, price)
        {

        }
    }
}
