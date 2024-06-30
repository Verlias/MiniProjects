using System;



namespace CarClass
{
    public abstract class Car
    {
        // Private fields with default initialization
        private int wheel = 0; // Assuming default value is 0
        private string color = ""; // Assuming default value is an empty string
        private double minSpeed = 0.0; // Assuming default value is 0.0
        private double maxSpeed = 0.0; // Assuming default value is 0.0



        public int Wheel
        {
            get { return wheel; }
            set { wheel = value; }
       
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double MinSpeed
        {
            get { return minSpeed; }
            set { minSpeed = value; }

        }

        public double MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
            
        }


        public Car(int wheel,string color, double minSpeed, double maxSpeed)
        {
            Wheel = wheel;
            Color = color;
            MinSpeed = minSpeed;
            MaxSpeed = maxSpeed;
        }

        //Abstract Method
        public abstract void DisplayInfo();
         
    }

    public class CoupeCar : Car
    {


        private const string model = "Coupe";

        public CoupeCar(int wheel, string color, double minSpeed, double maxSpeed)
            : base(wheel, color, minSpeed, maxSpeed)
        {

        }


        public override void DisplayInfo()
        {
            Console.WriteLine($"This Car is an {model}. It Has {Wheel} Wheels, and has a minimum speed of {MinSpeed} and max of {MaxSpeed}");
        }
    }


    public class SportsCar : Car
    {


        private const string model = "Sports Car";

        public SportsCar(int wheel, string color, double minSpeed, double maxSpeed)
            : base(wheel, color, minSpeed, maxSpeed)
        {

        }


        public override void DisplayInfo()
        {
            Console.WriteLine($"This Car is an {model}. It Has {Wheel} Wheels, and has a minimum speed of {MinSpeed} and max of {MaxSpeed}");
        }
    }

    public class SuperCar : Car
    {


        private const string model = "SuperCar";

        public SuperCar(int wheel, string color, double minSpeed, double maxSpeed)
            : base(wheel, color, minSpeed, maxSpeed)
        {

        }


        public override void DisplayInfo()
        {
            Console.WriteLine($"This Car is an {model}. It Has {Wheel} Wheels, and has a minimum speed of {MinSpeed} and max of {MaxSpeed}");
        }
    }

}
