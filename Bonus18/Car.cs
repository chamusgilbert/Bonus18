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
            this.carInfo = CarInfo(make, model, year, price);
        }

        public virtual string CarInfo(string make, string model, int year, double price)
        {
            return string.Format("{0,10}  {1,10}  {2,4}   {3,15}", make, model, year, price);
        }


    }
    class UsedCar : Car
    {

        public UsedCar(string make, string model, int year, double price, double miles)
            : base(make, model, year, price)
        {
            CarInfo(make, model, year, price, miles);
        }
        public static string CarInfo(string make, string model, int year, double price, double miles)
        {
            return string.Format("{0,10} {1,10} {2,4} {3,15} {4,15}", make, model, year, price, miles);
        }

    }
}
