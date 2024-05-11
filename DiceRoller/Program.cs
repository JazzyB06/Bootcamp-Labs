

using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Reflection.Metadata;

Console.WriteLine("Welcome to the Grand Circus Dice Roller App!");
Console.WriteLine("Please enter your number:");
int dice1 = 0;
int dice2 = 0;
int diceSides = int.Parse(Console.ReadLine());

if (diceSides == 6)
{
    dice1 = DiceRoll(diceSides);
    dice2 = DiceRoll(diceSides);
    string Check = DiceCombos(dice1, dice2);
    Console.WriteLine(Check);
}

else
{
    dice1 = DiceRoll(diceSides);
    dice2 = DiceRoll(diceSides);
    Console.WriteLine(dice1);
    Console.WriteLine(dice2);
}
//methods
static int DiceRoll(int diceSides)
{
    Random random = new Random();
    return random.Next(1, diceSides + 1);
}
static string DiceCombos(int d1, int d2)
{
    if (d1 == 1 && d2 == 1)
    {
        return "Snake Eyes";
    }
    else if ((d1 == 1 && d2 == 2) || (d1 == 2 && d2 == 1))
    {
        return "Ace Deuce";
    }
    else if (d1 == 6 && d2 == 6)
    {
        return "Box Car";
    }
    else
    {
        return "";
    }
}
try
{
    int[] myNumbers = { 1, 2, 3 };
    Console.WriteLine("Only numbers are acceptable.");
}
    catch (Exception e)
{
   Console.WriteLine("Something went wrong here!"); //error handling message
 }
Console.WriteLine($"You rolled {dice1} , {dice2}");
Console.WriteLine($"Your sum is {dice1 + dice2}");
Console.WriteLine("Would you like to roll again? 'Y' for 'yes' or 'N' for 'no?");
Console.ReadLine();
Console.WriteLine("Continue Rolling, please!");
Console.WriteLine("Thank you!");
static string Messages(int d1, int d2)
{
    if ((d1 == 1 && d2 == 1))
    {
        return "You've rolled Snake Eyes!";
    }
    else if ((d1 == 1 && d2 == 2) || (d1 == 2 && d2 == 1))
    {
        return "You've rolled Ace Deuce!";
    }
    else if (d1 == 6 && d2 == 6)
    {
        return "You've rolled Box Car!";
    }
    else
    {
        return "";
    }
    Console.WriteLine($"You rolled {d1} , {d2}");
    Console.WriteLine($"Your sum is {d1 + d2}");

}