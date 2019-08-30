using System;
using System.Collections.Generic;
using System.Text;
using Core.ApplicationService;
using Core.DomainService;
using Entity;
using Infrastructure.Repositories;

namespace ConsolePetShop
{
    class Menu
    {
        private IPetService petService;
        public void Run()
        {
            Pet pet1 = new Pet
            {
                Name = "Trex",
                Color = "White"
            };

            Pet pet2 = new Pet
            {
                Name = "Rex",
                Color = "black"
            };
            IPetRepository petRepository = new PetRepository();

            petService = new PetService(petRepository);
            petService.Add(pet1);
            petService.Add(pet2);
            StartMenu();

        }
        public void Print(String print)
        {
            Console.WriteLine(print);
        }
        public void StartMenu()
        {
            Console.WriteLine("Welcome, choose a service");
            Console.WriteLine("1 -List all pets");
            Console.WriteLine("2 -Create pet");
            Console.WriteLine("3 -Read pet");
            Console.WriteLine("4 -Edit pet");
            Console.WriteLine("5 -Delete pet");
            Console.WriteLine("6 - Exit");
            UserSelection();
        }

        public void UserSelection()
        {
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                   || selection < 1
                   || selection > 6)
            {
                Console.WriteLine("Please select a number between 1-6");
            }
            Console.Clear();


            switch (selection)
            {
                case 1:
                    ListAllPets();
                    break;

                case 2:
                    CreatePet();
                    break;

                case 3:
                    ReadPet();
                    break;
                case 4:
                    EditPet();
                    break;

                case 5:
                    DeletePet();
                    break;

                case 6:
                    Exit();
                    break;
            }
        }

        private void DeletePet()
        {
            var videoFound = FindPetByID();
            Console.WriteLine("Select which pet ID you want to delete");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Print("please search for a Pet ID");
            }

            Pet PetFound = null;
            foreach (var pet in petService.FindAllPets())
            {
                if (pet.Id == id)

                {
                    PetFound = pet;
                }
            }

            if (PetFound != null)
            {
                petService.RemovePet(PetFound.Id);

            }

            Print(" The Pet has been deleted");
        }

        private void Exit()
        {
            Print("ByeBye");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

        }

        public Pet FindPetByID()
        {
            {
                Console.WriteLine("Select which Pet ID you want to Edit");
                Console.WriteLine("Press Enter to continue");
                //Console.ReadLine();
                int id;
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("please search for a pet ID");
                }

                foreach (var pet in petService.FindAllPets())
                {
                    if (pet.Id == id)

                    {
                        return pet;
                    }
                }
                return null;
                //StartMenu();
            }
        }

        public void EditPet()
        {
            Pet findPetById = FindPetByID();
            Console.WriteLine("Name");
            findPetById.Name = Console.ReadLine();
            Console.WriteLine("Color");
            findPetById.Color = Console.ReadLine();
            StartMenu();

        }
        private void ReadPet()
        {
            Print("Reading pet");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            StartMenu();
        }

        private void CreatePet()
        {
            Print("Start creating a pet");

            Print("Name");

            String name = Console.ReadLine();

            Console.WriteLine("Color");

            String color = (Console.ReadLine());

            Console.WriteLine("Id");
            int selection;
            if (!int.TryParse(Console.ReadLine(), out selection))

            {
                Console.WriteLine("Please give the pet a number as an ID");
            }
            //int id = Convert.ToInt32(Console.ReadLine());

            petService.Add(new Pet()
            {
                Name = name,
                Color = color
            });
            Print(name + (" -- has been added to your list"));
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            StartMenu();
        }

        private void ListAllPets()
        {
            Print("Listing Pets");
            List<Pet> pets = petService.FindAllPets();

            for (int i = 0; i < pets.Count; i++)
            {
                Print($"{pets[i].Name} {pets[i].Id} {pets[i].Color}");

            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            StartMenu();

        }
    }
}
