using System;
using ToHModels;
using ToHBL;

namespace ToHUI
{
    public class HeroMenu : IMenu
    {
        private IHeroBL _heroBL;
        public HeroMenu(IHeroBL heroBL){

            _heroBL = heroBL;
        }
        public void Start(){

            Boolean stay = true;
            do{
                // Menu Start
                Console.WriteLine("Welcome to my Tour of Heroes app! What would you like to do?");
                Console.WriteLine("[0] Create a Hero");
                Console.WriteLine("[1] Get all Heroes");
                Console.WriteLine("[2] Search Hero by name.");
                Console.WriteLine("[3] Delete a hero.");
                Console.WriteLine("[4] Exit.");

                //Get user input.
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        try
                        {
                            CreateHero();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid Input");
                            continue;
                        }
                        break;
                    case "1":
                        GetHeroes();
                        break;
                    case "2":
                        SearchHero();
                        break;
                    case "3":
                        DeleteHero();
                        break;
                    case "4":
                        stay = false;
                        ExitRemarks();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Not part of Menu options!");
                        break;
                }
            } while(stay);
        }

        public void CreateHero(){
            // Create hero method/logic
            Hero newHero = new Hero();

            Console.WriteLine("Enter Hero Name: ");
            newHero.HeroName = Console.ReadLine();

            Console.WriteLine("Enter a HP Value: ");
            newHero.HP = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter SuperPower details: ");

            SuperPower newSuperPower = new SuperPower();
            Console.WriteLine("Enter SuperPower name: ");
            newSuperPower.Name = Console.ReadLine();

            Console.WriteLine("Enter SuperPower description: ");
            newSuperPower.Description = Console.ReadLine();

            Console.WriteLine("Enter SuperPower Damage: ");
            newSuperPower.Damage = int.Parse(Console.ReadLine());

            newHero.SuperPower = newSuperPower;
            Console.WriteLine("Set the element of the hero: ");
            newHero.ElementType = Enum.Parse<Element>(Console.ReadLine());
            
            _heroBL.AddHero(newHero);
            Console.WriteLine($"Hero Successfully created!");
        }

        public void GetHeroes(){
            foreach (var item in _heroBL.GetHeroes()){
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public void ExitRemarks(){
            Console.WriteLine("Goodbye friend. See you next time!");
        }

        public void SearchHero(){
            Console.WriteLine("Enter hero name: ");
            Hero foundHero = _heroBL.GetHeroByName(Console.ReadLine());
            if (foundHero == null){
                Console.WriteLine("No such hero found :<");
            } 
            else {
                Console.WriteLine(foundHero.ToString());
            }
        }

        public void DeleteHero(){
            Console.WriteLine("Enter the hero you wish to be removed from the roster: ");
            Hero hero2BDeleted = _heroBL.GetHeroByName(Console.ReadLine());
            if(hero2BDeleted == null){
                Console.WriteLine("We can't find the hero. They may have already been deleted. \nOr you typed their name wrong. This is a case sensitive application.");
            } else {
                _heroBL.DeleteHero(hero2BDeleted);
                Console.WriteLine($"Success!!!!!!!!!!!!!!!! { hero2BDeleted.HeroName } is gone from your hero collection.");
            }
        }
    }
}