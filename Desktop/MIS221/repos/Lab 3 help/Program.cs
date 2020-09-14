using System;

namespace Lab_3_help
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = GetUserChoice();
            string userInput = "";
            Random randomNumber= new Random();
            int number;
            number = randomNumber.Next(2); 
            string computerInput = "";
            string finalMessage = "";

            if(userChoice == 0)
            {
                userInput = "Rock";
            }
            else {
                if (userChoice == 1)
                {
                    userInput = "Paper";
                } 
                else {
                    if (userChoice == 2)
                    {
                        userInput = "Scissors";
                    }
                    else {
                        Console.WriteLine("Invalid entry try again");
                    }
                }
            
            }
            Console.WriteLine("User input is {0}" , userInput);
            if(number == 0)
            {
                computerInput = "Rock";
            }
            else {
                if (number == 1)
                {
                    computerInput = "Paper";
                } 
                else {
                    if (number == 2)
                    {
                        computerInput = "Scissors";
                    }
                    else {
                        Console.WriteLine("Invalid entry try again");
                    }
                }
            
            }
            Console.WriteLine("Computer input is {0}" , computerInput);
            if (number == 0 &&  userChoice == 0 || number == 1 &&  userChoice == 1 || number == 2 &&  userChoice == 2)
            {
                finalMessage = "It's a tie!";
            }else{
                if ( number == 0 && userChoice ==2 || number == 1 && userChoice ==0 || number ==2 && userChoice == 1) 
                {
                    finalMessage = "Computer Wins.";
                }
                else{
                    if(number == 2 && userChoice == 0 || number == 0 && userChoice ==1 || number ==1 && userChoice == 2)
                    {

                    }
                    else{
                        finalMessage = "error";
                    }

                }
            }
            Console.WriteLine(finalMessage);
        }
        
        static int GetUserChoice()
        {
            Console.WriteLine("Let's play Rock Paper scissors! Enter 0 for rock, 1 for paper, and 2 for scissors.");
            return int.Parse(Console.ReadLine()); 
        }
    
        
    }
}
