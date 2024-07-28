using System;
using System.Runtime.CompilerServices;
using Pets;
using PetHouseClass;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
          
          
            Dog myobj = new Dog("Logan");
            myobj.DisplayPetInfo();
            myobj.PetSound();

            Cat mycat = new Cat("Meow Kitty");
            mycat.DisplayPetInfo();
            mycat.PetSound();

            Snake mysnake = new Snake("Sneaky Snake");
            mysnake.DisplayPetInfo();
            mysnake.PetSound();

            Dino mydino = new Dino("Dan the Dino");
            mydino.DisplayPetInfo();
            mydino.PetSound();

            Hawk myhawk = new Hawk("America Hawk");
            myhawk.DisplayPetInfo();
            myhawk.PetSound();

            Duck myduck = new Duck("Ducky");
            myduck.DisplayPetInfo();
            myduck.PetSound();

            Turtle myturtle = new Turtle("thomas");
            myturtle.DisplayPetInfo();
            myturtle.PetSound();

            PetHouse house = new PetHouse();
            house.AddPet(myobj);
            house.AddPet(mycat);
            house.DisplayPets();
            house.RemovePet(mycat);
            house.DisplayPets();
    



        }
    }
}
