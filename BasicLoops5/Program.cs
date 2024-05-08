using System.Diagnostics.Metrics;

int KeyCode = 0;
int userinput = 0;

while (KeyCode != 13579)
{
    Console.WriteLine("Kindly, enter your Key Code, please.");
    KeyCode = int.Parse(Console.ReadLine());
    if (KeyCode == 13579)
    {
        Console.WriteLine("It's good to be home! Hello, Jasmine!");
    }
    do
    {
        Console.WriteLine("Your answer is incorrect");
        userinput = int.Parse(Console.ReadLine());

        break;

    }
    while (userinput != 0);
    {
        Console.WriteLine("You've reached the maximum amount of attempts.");
        Console.ReadLine();
    }
    while (true) ;
}