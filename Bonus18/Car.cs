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
            return string.Format("{0,10}  {1,9} {2,4}   {3,12}", make, model, year, price);
        }


    }
   
}
