using System;
using CarClass;

using GarageClass;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        CoupeCar coupe = new CoupeCar(4, "Blue", 100, 200);
        SportsCar sports = new SportsCar(4, "Red", 120, 220);
        SuperCar super = new SuperCar(4, "Black", 150, 250);

        // Display information about each car
        coupe.DisplayInfo();
        sports.DisplayInfo();
        super.DisplayInfo();

        Garage mygarage = new Garage();
        mygarage.AddCar(coupe);
        mygarage.DisplayCars();


    }
}