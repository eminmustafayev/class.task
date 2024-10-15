using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("mercedes" , "e60" , 3240 , 4);
            car1.ShowFullInfo();
            Car car2 = new Car("bmw", "F10", 3240, 4);
            car2.ShowFullInfo();

            Moto moto1 = new Moto("tufan", "uy37", 1211, 2);
            moto1.ShowFullInfo();
            Moto moto2 = new Moto("tufan", "ik837", 9811, 2);
            moto1.ShowFullInfo();
        }
    class Vehicle
        {
            public string Brand;
            public string Model;
            public double Mile;
            public Vehicle(string brand, string model, double mile)
            {
                if ( brand==" " || model==" ")
                {
                    Console.WriteLine("Brand and model must enter");
                }
                Brand = brand;
                Model = model;
                Mile = mile;




            }
            public void ShowFullInfo()
            {
                Console.WriteLine($"Brand:{Brand},Model:{Model},Mile:{Mile}");
            }

        }
    class Car : Vehicle
        {
            public int DoorNum;

            public Car( string model, string brand, double mile, int doorNum) : base(model, brand, mile)
            {
                DoorNum = doorNum;
            }
            public void ShowFullInfo()
            {
                base.ShowFullInfo();
                Console.WriteLine("doorNum : " + DoorNum);

            }

        }
    class Moto: Vehicle
        {
            public int WhellNum;

            public Moto( string model, string brand, double mile, int whellNUm) : base(model, brand, mile)
            {
                WhellNum = whellNUm;
            }
            public void ShowFullInfo()
            {
                base.ShowFullInfo();
                Console.WriteLine("whellNum :" + WhellNum);

            }

        }


    }
}