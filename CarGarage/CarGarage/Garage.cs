using System;
using CarClass;

namespace GarageClass
{
    public class Garage
    {

        private List<Car> cars;


        public Garage()
        {

            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
            Console.WriteLine($"Added {car.GetType().Name} to the garage.");

        }

        public void RemoveCar(Car car)
        {
            if (cars.Remove(car))
            {
                Console.WriteLine($"Removed {car.GetType().Name} from the garage.");
            }
            else
            {
                Console.WriteLine($"Car {car.GetType().Name} not found in the garage.");
            }
        }

        // Method to display all cars in the garage
        public void DisplayCars()
        {
            Console.WriteLine("Cars in the garage:");
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.GetType().Name} - {car.Color}");
            }
        }

    }

}
