using System;
using System.ComponentModel.Design;

namespace LabNumberAnalyzer;
class LabNumberAnalyzerProgram
{
    static void Main(string[] args)
    {
        bool programRuns = true;
        bool programRunsAgain;
        string userName;
        string userInput;
        string userAnswer;
        bool isAnInteger;

        Console.WriteLine("Welcome to the Number Analyzer Program!");
        Console.WriteLine("");
        Console.WriteLine("Thanks for joining us today! Let us know who you are!");
        Console.WriteLine("Please enter your name:");
        userName = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"It's a pleasure meeting you {userName} ! Let's begin analyzing your numbers right now!");
        Console.WriteLine("");

        while (programRuns)
        {
            Console.WriteLine("Please enter an integer between 1 and 100");
            userInput = Console.ReadLine();
            isAnInteger = int.TryParse(userInput, out int integer);
            if (isAnInteger)
            {
                if (integer <= 100 && integer >= 1)
                {
                    if (integer % 2 == 0 && integer < 25)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Your integer {integer}, is even and is between 26 and 60 inclusively.");
                        Console.WriteLine("");
                    }
                    else if (integer % 2 == 0 && integer > 60)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Your integer {integer} is both even and greater than 60.");
                        Console.WriteLine("");
                    }
                    else if (integer % 2 != 0 && integer < 60)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Your integer {integer} is both odd and less than 60.");
                        Console.WriteLine("");
                    }
                    else if (integer % 2 != 0 && integer > 60)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Your integer {integer} is both odd and greater than 60. ");
                        Console.WriteLine("");
                    }
                }
                programRunsAgain = true;
                while (programRunsAgain)
                {
                    Console.WriteLine($"Would you like to analyze another integer {userName}? ");
                    Console.WriteLine("Enter 'Y' for 'Yes' to analyze another integer, or enter 'N' for 'No' in order to exit: ");
                    userAnswer = Console.ReadLine();
                    if (userAnswer == "Y" || userAnswer == "Yes")
                    {
                        Console.WriteLine("");
                        programRunsAgain = false;
                        programRuns = true;
                    }
                    else if (userAnswer == "N" || userAnswer == "No")
                    {
                        Console.WriteLine("");
                        programRunsAgain = false;
                        programRuns = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("My apologies, but I can't process your request right now");
                        Console.WriteLine("");
                        programRunsAgain = false;

                    }
                }
            }

            else if (integer > 100 || integer < 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Unfortunately, that integer is out of range. Please try again.");
                Console.WriteLine("");
                programRuns = true;

            }


            else
            {
                Console.WriteLine("Sorry, but you didn't enter an integer. Please try again.");
                Console.WriteLine("");
                programRunsAgain = true;
            }

        }
        Console.WriteLine($"Thanks for using the Number Analyzer Program today, {userName}!");
        Console.WriteLine("Bye...");
    }
}