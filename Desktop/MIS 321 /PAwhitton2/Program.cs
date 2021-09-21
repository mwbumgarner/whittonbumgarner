using System;
using System.Collections.Generic;
namespace PAwhitton2
{
    class Program
    {
        static void Main(string[] args)
        {
           IThrow hamburgler = new HamburgerThrow();
           IThrow fryKid = new FryThrow();
           IThrow ronald = new ChickenNuggetThrow();

           Character playerOne = new Character();
           Character playerTwo = new Character();
           Menu(playerOne, playerTwo, hamburgler,fryKid,ronald);

           playerOne.ThrowBehavior = new HamburgerThrow();
           
           List<Character> myCharacters = new List<Character>();
           myCharacters.Add(playerOne);
           myCharacters.Add(playerTwo);
           
         
    
           Fight(playerOne, playerTwo);

           

        }
        public static void Menu(Character playerOne, Character playerTwo, IThrow hamburgler,IThrow fryKid, IThrow ronald){
            Console.WriteLine("Welcome to the food fight!");
            Console.WriteLine("Are you ready!");
            Console.WriteLine("Enter your name");
            string playerOneName = Console.ReadLine();
            
            Console.WriteLine($"Welcome {playerOneName}! Now its time to pick a character.");
            Console.WriteLine("Enter 1 to be a Hamburgler, 2 to be Ronald Mcdonald, and 3 to be FryKid.");
            string menuOption= Console.ReadLine();
            while (menuOption != "1" && menuOption != "2" && menuOption != "3"){
                Console.WriteLine("Invalid Option. ");
                Console.WriteLine("Enter 1 to be a Hamburgler, 2 to be Ronald Mcdonald, and 3 to be FryKid.");
            }
            if (menuOption == "1" || menuOption == "2" || menuOption == "3"){
                if (menuOption == "1"){
                    Console.WriteLine("Player 1 chose Hamburgler");
                    playerOne.ThrowBehavior = new HamburgerThrow();
                

                }
                if (menuOption == "2"){
                    Console.WriteLine("Player One Chose Ronald McDonald");
                    playerOne.ThrowBehavior = new ChickenNuggetThrow();    
                }
                if(menuOption == "3"){
                    Console.WriteLine("Player One chose The Fry Kids ");
                    playerOne.ThrowBehavior= new FryThrow();        
                }
                playerOne.ThrowBehavior.Throw();
            }
            Console.WriteLine("Player Two's turn!");
            Console.WriteLine("Enter your name");
            string playerTwoName = Console.ReadLine();
            Console.WriteLine($"Welcome {playerTwoName}! Now its time to pick a character.");
            Console.WriteLine("Enter 1 to be a Hamburgler, 2 to be Ronald Mcdonald, and 3 to be FryKid.");
            menuOption= Console.ReadLine();
            while (menuOption != "1" && menuOption != "2" && menuOption != "3"){
                Console.WriteLine("Invalid Option. ");
                Console.WriteLine("Enter 1 to be a Hamburgler, 2 to be Ronald Mcdonald, and 3 to be FryKid.");
                menuOption = Console.ReadLine();
            }
            if (menuOption == "1" || menuOption == "2" || menuOption == "3"){
                if (menuOption == "1"){
                    Console.WriteLine("Player 1 chose Hamburgler");
                    playerTwo.ThrowBehavior = new HamburgerThrow();
                }
                if (menuOption == "2"){
                    Console.WriteLine("Player One Chose Ronald McDonald");
                    playerOne.ThrowBehavior = new ChickenNuggetThrow();  
                }
                if(menuOption == "3"){
                    Console.WriteLine("Player One chose The Fry Kids ");
                    playerOne.ThrowBehavior= new FryThrow();   
                }
                playerTwo.ThrowBehavior.Throw();
            }

        }
       
            
            
        static void Fight(Character one, Character two){
            Random rand = new Random();
            int randomChar = rand.Next(1, 3);
            if (randomChar ==1){
                Console.WriteLine("After being randomly selected, Player one plays first. ");
                double bonus =CharacterUtility.GetBonus(one, two);
                while(one.Health >0 && two.Health >0){
                    bonus = CharacterUtility.GetBonus(one, two);
                    double y = (two.DefensivePower/100);
                    double damage = (one.ThrowPower)*(y)* bonus;
                    two.Health = two.Health - damage;
                    Console.WriteLine($"Player one attacked player two. The damage caused by player one totaled to {damage}");
                    Console.WriteLine($"Player two's new health is {two.Health}");
                    DisplayStats(one,two);
                    if (one.Health >0 && two.Health >0){
                        bonus = CharacterUtility.GetBonus(two, one);
                        Console.WriteLine("It is now time for Player two to attack");
                        System.Console.WriteLine(one.DefensivePower/100);               
                        double x = (one.DefensivePower/100);                              // a percent 
                        double damageTwo = (two.ThrowPower)*(x)* bonus;             
                        one.Health = one.Health - damageTwo;                              
                        Console.WriteLine($"Player two attacked player one. The damage caused by player two totaled to {damageTwo}");
                        Console.WriteLine($"Player ones's new health is {one.Health}");
                        DisplayStats(one,two);
                    }
                }
                if(one.Health<0 && two.Health<0){
                    Console.WriteLine("Both players health reached below zero. Both loose :(");
                }
                else if(one.Health>two.Health){
                    Console.WriteLine("Player one wins!!");
                    Console.WriteLine($"PlayerOne's health was {one.Health} while player two has below zero.");
                }else{
                    Console.WriteLine("Player two wins!!");
                    Console.WriteLine($"Player Two's health was {two.Health} while player two has below zero.");
                }
            }
            else if (randomChar ==2){
                Console.WriteLine("After being randomly selected, Player two plays. ");
                double bonus = CharacterUtility.GetBonus(two, one);
                while(one.Health >0 && two.Health >0){
                    bonus = CharacterUtility.GetBonus(two, one);
                    Console.WriteLine("Player two attacks!");
                    double x = one.DefensivePower/100;
                    double damageTwo = (two.ThrowPower)*(x)* bonus;
                    one.Health = one.Health - damageTwo;
                    Console.WriteLine($"Player two attacked player one. The damage caused by player two totaled to {damageTwo}"); 
                    Console.WriteLine($"Player ones's new health is {one.Health}");
                    DisplayStats(one,two);
                    if (one.Health >0 && two.Health >0){
                        bonus = CharacterUtility.GetBonus(one, two);
                        double y = (two.DefensivePower/100);
                        double damage = (one.ThrowPower)*(y)* bonus;
                        two.Health = two.Health - damage;
                        Console.WriteLine($"Player one attacked player two. The damage caused by player one totaled to {damage}");
                        Console.WriteLine($"Player two's new health is {two.Health}");
                        DisplayStats(one,two);
                    }
                }
                if(one.Health<0 && two.Health<0){
                    Console.WriteLine("Both players health reached below zero. Both loose :(");
                }
                else if(one.Health>two.Health){
                    Console.WriteLine("Player one wins!!");
                    Console.WriteLine($"PlayerOne's health was {one.Health} while player two has below zero.");
                }else{
                    Console.WriteLine("Player two wins!!");
                    Console.WriteLine($"Player Two's health was {two.Health} while player two has below zero.");
                }
            }
        }
        public static void DisplayStats(Character one, Character two){
            Console.WriteLine("Would you like to see the current stats of each player?");
            Console.WriteLine("Enter 5 to see stats. If not, enter any othehr digit to continue");
            string menuOption = Console.ReadLine();
            if (menuOption == "5"){
                Console.WriteLine("Player One:");
                Console.WriteLine($"Player one is {one.Name}");
                Console.WriteLine($"Health: {one.Health}");
                Console.WriteLine($"Max Strengh: {one.MaxPower}");
                Console.WriteLine($"Defensive Power: {one.DefensivePower}");
                Console.WriteLine($"Throw Power: {one.ThrowPower}");
                Console.WriteLine("Player Two:");
                Console.WriteLine($"Player two is {two.Name}");
                Console.WriteLine($"Health: {two.Health}");
                Console.WriteLine($"MaxStrengh: {two.MaxPower}");
                Console.WriteLine($"Defensive Power: {two.DefensivePower}");
                Console.WriteLine($"Throw Power: {two.ThrowPower}");
            }
            

            
        }
    }
}
           
            
        
            
            
            
    
        
        
            
           
           
        



       
             

