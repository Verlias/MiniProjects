using System;
using Shapes;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sphere myobj = new Sphere(2, 3);
            myobj.DisplayInfo();
            Cube newcube = new Cube(10);
            newcube.DisplayInfo();

        }
    }
}
