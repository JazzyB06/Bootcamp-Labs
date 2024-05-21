

using System.ComponentModel.Design;
using System.Numerics;

Console.WriteLine(GetDaysLeft(50, 7));
static double GetDaysLeft(double num1, double num2)
{
    return num1 - num2;
}


Console.WriteLine($"Please enter a number:");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);
if (number <= 6) ;
{
    Console.WriteLine("The next topic is Continents");
    Console.WriteLine("");
}
while (false) ;

if (number <= 20) ;
{
    Console.WriteLine("The next topic is Oceans");
    Console.WriteLine("");
}
while (false) ;
if (number <= 37) ;
{
    Console.WriteLine("The next topic is The Solar System");
    Console.WriteLine("");
}
while (false) ;
if (number <= 50) ;
{
    Console.WriteLine("There are no more tests left");
    Console.WriteLine("");
}
Console.WriteLine($"You have {userInput} days left");
Console.WriteLine("");
Console.WriteLine("There are more days left of class ");
Console.WriteLine("Please choose another day of class. Goodbye!");
