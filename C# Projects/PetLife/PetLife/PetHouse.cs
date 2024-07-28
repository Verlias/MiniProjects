using System;
using Pets;


namespace PetHouseClass
{
    public class PetHouse
    {
        private List<Pet> pets;

        public PetHouse()
        {
            pets = new List<Pet>();
        }

        public void AddPet(Pet pet)
        {
            pets.Add(pet);
            Console.WriteLine($"Added {pet.GetType().Name} to the garage.");

        }

        public void RemovePet(Pet pet)
        {
            if (pets.Remove(pet))
            {
                Console.WriteLine($"Removed {pet.GetType().Name} from the PetHouse.");
            }
            else
            {
                Console.WriteLine($"Pet {pet.GetType().Name} not found in the PetHouse.");
            }
        }

        // Method to display all cars in the garage
        public void DisplayPets()
        {
            Console.WriteLine("Pet in the PetHouse:");
            foreach (var Pet in pets)
            {
                Pet.DisplayPetInfo();
            }
            Console.WriteLine(pets[0]); // Find by index
        }
    }



}