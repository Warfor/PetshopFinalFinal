using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
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
                Birthdate = DateTime.Now,
                Name = " Trex ",
                Color = " White ",
                Price = 10000,
                Race = "Dog",
                SoldDate = DateTime.Now,
                PreviosOwner = " Bente "
            };

            Pet pet2 = new Pet
            {
                Birthdate = DateTime.Now,
                Name = " Rex ",
                Color = " black ",
                Price = 5000 ,
                Race = "Cat",
                SoldDate = DateTime.Now,
                PreviosOwner = " Bodil "
            };
            Pet pet3 = new Pet
            {
                Birthdate = DateTime.Now,
                Name = " Ricko ",
                Color = " black ",
                Price = 3000,
                Race = "Dog",
                SoldDate = DateTime.Now,
                PreviosOwner = " Klaus "
            };
            Pet pet4 = new Pet
            {
                Birthdate = DateTime.Now,
                Name = " Teison ",
                Color = " white ",
                Price = 7500,
                Race = " Dog ",
                SoldDate = DateTime.Now,
                PreviosOwner = " Camille "
            };
            Pet pet5 = new Pet
            {
                Birthdate = DateTime.Now,
                Name = " Coli ",
                Color = " White ",
                Price = 2000,
                Race = "Goat",
                SoldDate = DateTime.Now,
                PreviosOwner = " Bo "
            };
            Pet pet6 = new Pet
            {
                Birthdate = DateTime.Now,
                Name = " Dummi ",
                Color = " orange ",
                Price = 1000,
                Race = " Cat ",
                SoldDate = DateTime.Now,
                PreviosOwner = " Katrin "
            };
            IPetRepository petRepository = new PetRepository();

            petService = new PetService(petRepository);
            petService.Add(pet1);
            petService.Add(pet2);
            petService.Add(pet3);
            petService.Add(pet4);
            petService.Add(pet5);
            petService.Add(pet6);

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
            Console.WriteLine("3 -Edit/Update pet");
            Console.WriteLine("4 -Delete pet");
            Console.WriteLine("5 - Exit");
            Print("6 sortbyprice");
            Print("7 FindCheapest");
            Print("8 SearchPets");
            UserSelection();
        }

        public void UserSelection()
        {
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                   || selection < 1
                   || selection > 8)
            {
                Console.WriteLine("Please select a number between 1-8");
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
                    EditPet();
                    break;

                case 4:
                    DeletePet();
                    break;

                case 5:
                    Exit();
                    break;
                
                case 6:
                    ListSortedPrice(petService.SortByPrice(petService.FindAllPets()));
                    break;
                
                case 7:
                    ListCheapest(petService.SortByPrice(petService.FindAllPets()));
                    break;
                
                case 8:
                    SearchRace();
                    break;
                    
                    
            }
        }

    

        private void DeletePet()
        {
            var videoFound = FindPetByID();
            Print("Select which pet ID you want to delete");
            Print("Press Enter to continue");
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
            StartMenu();
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
                Console.WriteLine("Select Pet ID");
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
            Console.WriteLine("race");
            findPetById.Race = Console.ReadLine();
            Console.WriteLine("price");
            findPetById.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("previousOwner");
            findPetById.PreviosOwner = Console.ReadLine();
            StartMenu();
        }
       
        private void CreatePet()
        {
            Print("Start creating a pet");
            Print("Name");
            String name = Console.ReadLine();
            Print("Color");
            String color = Console.ReadLine();
            Print("Race");
            String race = Console.ReadLine();
            Print("Price");
            Double price = Convert.ToDouble(Console.ReadLine());
            Print("previousowner");
            String previousowner = Console.ReadLine();

            Console.WriteLine("Id");
            int selection;
            if (!int.TryParse(Console.ReadLine(), out selection))

            {
                Console.WriteLine("Please give the pet a number as an ID");
            }
            petService.Add(new Pet()
            {
                Name = name,
                Color = color,
                Race = race,
                Price = price,
                PreviosOwner = previousowner,

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
                Print($"{pets[i].Name}" +" " +
                      $"{pets[i].Id}" + " " +
                      $"{pets[i].Color}" + " " +
                      $"{pets[i].Birthdate}" + " " +
                      $"{pets[i].PreviosOwner}" + " " +
                      $"{pets[i].Price} " + " " +
                      $"{pets[i].SoldDate} " + " " +
                      $"{pets[i].Race}");

            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            StartMenu();

        }
        private void ListSortedPrice(List<Pet> pets)
        {
            Print("Listing sorted price");

            for (int i = 0; i < pets.Count; i++)
            {
                Print($"{pets[i].Name}" +
                      $"{pets[i].Id}" +
                      $"{pets[i].Color}" +
                      $"{pets[i].Birthdate}" +
                      $"{pets[i].PreviosOwner}" +
                      $"{pets[i].Price} " +
                      $"{pets[i].SoldDate} " +
                      $"{pets[i].Race}");

            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            StartMenu();

        }

        private void ListCheapest(List<Pet> pets)
        {
            Print("Listing cheapest Pet");
            Print($"{pets[0].Name}" +
                  $"{pets[0].Id}" +
                  $"{pets[0].Color}" +
                  $"{pets[0].Birthdate}" +
                  $"{pets[0].PreviosOwner}" +
                  $"{pets[0].Price} " +
                  $"{pets[0].SoldDate} " +
                  $"{pets[0].Race}");
        }

        private void SearchRace()
        {
         
                Print("Write to search for race");
                String search = Console.ReadLine();
                List<Pet> pets = petService.SearchRace(search);
            Print("Listing sorted price");

            for (int i = 0; i < pets.Count; i++)
            {
                Print($"{pets[i].Name}" +
                      $"{pets[i].Id}" +
                      $"{pets[i].Color}" +
                      $"{pets[i].Birthdate}" +
                      $"{pets[i].PreviosOwner}" +
                      $"{pets[i].Price} " +
                      $"{pets[i].SoldDate} " +
                      $"{pets[i].Race}");

            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            StartMenu();

        }
    
    }
}
