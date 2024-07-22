using System;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract double Area();

        public abstract double Perimeter();

        public abstract double Volume();

        public abstract void DisplayInfo();
    }


    public class Sphere : Shape
    {
        private double radius;
        private double height;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; } 
        }


        public Sphere(double Radius, double Height) 
        {
            radius = Radius;
            height = Height;
        }

        public override double Area()
        {
            return (Math.PI * radius * radius);
        }

        public override double Perimeter()
        {
            return (2 * Math.PI * radius);
        }

        public override double Volume()
        {
            return (Math.PI * radius * 2 * height);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"This Sphere area is {Area()}, the volume is {Volume()}, and the Perimeter is {Perimeter()}" );
        }

    }

    public class Cube : Shape
    {
        private double edges;

        public double Edges
        {
            get { return edges; }
            set { edges = value; }
        }

        public Cube(double Edges)
        {
            edges = Edges;
        }

        public override double Area() 
        {
            return (6 * edges * edges);
        }

        public override double Perimeter()
        {
            return (12 * edges);
        }

        public override double Volume()
        {
            return (edges * edges * edges);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"This Cube area is {Area()}, the volume is {Volume()}, and the Perimeter is {Perimeter()}");
        }

    }

}