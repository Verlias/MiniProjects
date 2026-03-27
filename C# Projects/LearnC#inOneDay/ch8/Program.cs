
using System.IO.Compression;
using System.IO.Pipes;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace OOP
{
    class Member
    {
        /*
        A protected field is a field that is only accessible within the class
        in which it is declared and any class that is derived from it.
        */
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameters");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }
        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID +
            "\nMember Since: " + memberSince + "\nTotal Annual Fee: " +
            annualFee;
        }

        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }
    }

    //Inheriting the Member class | Child Class
    class NormalMember : Member
    {
        //The constructor of a child class is built upon the parent's class.
        //Whenever we create a child object, the parent class constructor is always
        //Called first.


        //This will call the parameterless parent class constructor then also call this constuctor
        public NormalMember()
        {
            Console.WriteLine("Child constructor with no parameters");
        }
        

        //the string remarks parameter is used inside the child constructor
        //The second, third, fourth parameters are not used in the child constructor
        public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public override void CalculateAnnualFee()
        {
            //Writing Annualfee we are accessing protected field in the parent class
            annualFee = 100 + 12*30;
        }
    }

    class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince) : base (name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 3 parameters");
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }

    //Abstract Classes cannot be instanitated
    abstract class MyClass
    {
        private string message = "Hello C#";
        
        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
        public abstract void PrintMessageAbstract();
    }

    class ClassA : MyClass
    {
        public override void PrintMessageAbstract()
        {
            Console.WriteLine("C# is fun!");
        }
    }

    interface IShape
    {
        int MyNumber {get; set;}
        void InterfaceMethod();
    }

    class ClassB : IShape
    {
        private int myNumber;
        public int MyNumber
        {
            get 
            {
                return myNumber;
            }
            set
            {
                if (value < 0)
                {
                    myNumber = 0;
                }
                else
                {
                    myNumber = value;
                }
            }
        }

        public void InterfaceMethod()
        {
            Console.WriteLine("The Number is {0}", MyNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Member[] clubMembers = new Member[5];
            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

            foreach (Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
            }

            if (clubMembers[0].GetType() == typeof(VIPMember))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            ClassA a = new ClassA();
            a.PrintMessage();
            a.PrintMessageAbstract();
            ClassB b = new ClassB();
            b.MyNumber = 5;
            b.InterfaceMethod();

        
        
        
        }
    }
}