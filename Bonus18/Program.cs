using System;
using System.Collections.Generic;
namespace Bonus18
{
    class Program
    {
        static void Main()
        {
            int c = 1, b = -1;
            List<Car> carLot = MakeLot();
            Console.WriteLine("Welcome to Grand Circus' Car Dealership!");
            ViewLot(c, carLot);
            b = BuyOne(carLot);
            carLot.RemoveAt(b - 1);
            ViewLot(c, carLot);
            BuyMore(b, c, carLot);
            Console.WriteLine("GoodBye!");

        }

        public static List<Car> MakeLot()
        {
            UsedCar car1 = new UsedCar("Toyota", "Prius", 2008, 10000);
            UsedCar car2 = new UsedCar("Hyandai", "Santa Fe", 2007, 11200);
            Car car3 = new Car("Chevy", "Cobalt", 2009, 45000);
            Car car4 = new Car("Chevy", "Mustang", 2018, 99000);
            Car car5 = new Car("Jeep", "Wrangler", 2015, 60600);
            UsedCar car6 = new UsedCar("Chevrolet", "Cavalier", 2001, 2000);

            List<Car> carLot = new List<Car>() { car1, car2, car3, car4, car5, car6 };

            return carLot;
        }
        public static int BuyOne(List<Car> list)
        {
            Console.WriteLine("Pick a car to buy by it's number");
            bool typeBetter = int.TryParse(Console.ReadLine(), out int buying);


            while (typeBetter == false || buying > list.Count || buying < 1)
            {
                Console.WriteLine("We dont have a car that meets that number or discription");
                Console.WriteLine("Pick a car to buy by it's number");
                typeBetter = int.TryParse(Console.ReadLine(), out buying);
            }
            return buying;
        }
        public static void ViewLot(int c, List<Car> carLot)
        {
            Console.WriteLine("Take a look at our cars:");
            foreach (Car item in carLot)
            {

                Console.WriteLine(c + item.carInfo);
                c++;
            }
        }
        public static void BuyMore(int b, int c, List<Car> carLot)
        {
            Console.WriteLine("Would you like to buy more?");
            string reply = Console.ReadLine().ToLower();
            if (carLot.Count == 0)
            {
                Console.WriteLine("Sorry, We are all out of cars");
                return;
            }
            else if (reply == "y" || reply == "yes")
            {
                b = BuyOne(carLot);
                carLot.RemoveAt(b - 1);
                ViewLot(c, carLot);
                BuyMore(b, c, carLot);
            }
            else if (reply == "n" || reply == "no")
            {
                Console.WriteLine("Thanks for your business");
                return;

            }
            else
            {
                Console.WriteLine("I did not understand you, say again?");
                BuyMore(b, c, carLot);
            }
        }
    }
}
