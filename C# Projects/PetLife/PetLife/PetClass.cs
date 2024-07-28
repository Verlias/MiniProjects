using System;

namespace Pets
{
    public abstract class Pet
    {
        public abstract void DisplayPetInfo();

        public abstract void PetSound();
    }

    //Dog class
    public class Dog : Pet
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Dog(string Name)
        {
            name = Name;
        }

        public override void DisplayPetInfo()
        {
            Console.WriteLine($"You have a pet named {Name}, and they are a Dog!");
        }

        public override void PetSound()
        {
            Console.WriteLine($"Bark Bark! - {Name} said");
        }
    }

    //Cat Class
    public class Cat : Pet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Cat(string Name)
        {
            name = Name;
        }

        public override void DisplayPetInfo()
        {
            Console.WriteLine($"You have a pet named {Name}, and they are a Cat!");
        }

        public override void PetSound()
        {
            Console.WriteLine($"Meowwwwww! - {Name} said");
        }
    }

    //Snake Class
    public class Snake : Pet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Snake(string Name)
        {
            name = Name;
        }

        public override void DisplayPetInfo()
        {
            Console.WriteLine($"You have a pet named {Name}, and they are a Snake!");
        }

        public override void PetSound()
        {
            Console.WriteLine($"Sssssssss - {Name} said");
        }
    }

    //Dino Class
    public class Dino : Pet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Dino(string Name)
        {
            name = Name;
        }

        public override void DisplayPetInfo()
        {
            Console.WriteLine($"You have a pet named {Name}, and they are a Dino!");
        }

        public override void PetSound()
        {
            Console.WriteLine($"ROARRRRR - {Name} said");
        }
    }

    //Hawk class
    public class Hawk : Pet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Hawk(string Name)
        {
            name = Name;
        }

        public override void DisplayPetInfo()
        {
            Console.WriteLine($"You have a pet named {Name}, and they are a Hawk");
        }

        public override void PetSound()
        {
            Console.WriteLine($"SWAKKKKKK - {Name} said");
        }
    }

    //Duck Class
    public class Duck : Pet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Duck(string Name)
        {
            name = Name;
        }

        public override void DisplayPetInfo()
        {
            Console.WriteLine($"You have a pet named {Name}, and they are a Duck");
        }

        public override void PetSound()
        {
            Console.WriteLine($"Quack Quack - {Name} said");
        }

    }

    //Turtle Class
    public class Turtle : Pet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Turtle(string Name)
        {
            name = Name;
        }

        public override void DisplayPetInfo()
        {
            Console.WriteLine($"You have a pet named {Name}, and they are a Turtle");
        }

        public override void PetSound()
        {
            Console.WriteLine($".... - {Name} said");
        }
    }
}
