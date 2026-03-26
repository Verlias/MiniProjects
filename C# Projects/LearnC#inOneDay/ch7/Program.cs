using System;
using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;


namespace Classes
{
    class Staff
    {

        //Fields
        //A field can either be private, public, protected or internal
        //private fields in this case means it could only be accessed within the Staff class
        //The reason why we need these fields to be private is because there is no need
        // for other classes to know about those fields.

        /*
        This is known as encapsulation. Encapsulation enables an object to hide data and behaviour from other classes
        that do not need to know about them.
        This makes it easier for us to make changes to our code in future if necessary.
        We can safely change the value of hourlyRate inside Staff Class without affecting other classes.

        We also dont want other classes to freely modify them.
        This helps to prevent the fields form being corrupted

        Properties 
        commmonly used to provide access to a private field in cases where the field is needed by other classes.
        Gives us greater control over what rights other classes have when assessing these private fields.

        */
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------------");
        }

        public Staff(string firstName, String lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------------");
        }

        // PascalCasing for Property Names
        public int HoursWorked
        {
            get
            {
                return hWorked;
            }

            //By default getter and setters have same access level as the property itself
            // If you want to declare the setter so that other classes cannot modify your private field.
            set
            // Value is a keyword when it used inside a setter. It refers to the value that is on the
            // Right side of the assignment statement when users use a property to set the value of the private
            // Field
            {
                if (value > 0)
                hWorked = value;
                else
                hWorked = 0;
            }
        }

        // Method 
        // this Method is accessiable everywhere in the program (not just within the staff class)
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }

        /*
        A Method can access all the fields and properties that are declared
        inside the class. In addition, it can declare its own variables.
        */
        public int CalculatePay()
        {
            PrintMessage();

            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }

        /*
        You can create two methods of the same name as long as they have
        different signatures. This is known as overloading. The signature
        of a method refers to the name of the method and the parameters that it has
        */

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();
            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", hourlyRate = "
+ hourlyRate + ", hWorked = " + hWorked;
        }


    }
    class Program
    {
        //All Programs in C# must have a entry point of the Main()fuction
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //ClassName objectName = new ClassName(arguments);

            int pay;
            Staff staff1 = new Staff("Peter");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Jane", "Lee");
            staff2.HoursWorked = 160;
            pay = staff2.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);

            Staff staff3 = new Staff("Carol");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);
        }
    }
}
