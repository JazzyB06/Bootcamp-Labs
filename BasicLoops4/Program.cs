
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
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Your answer is incorrect");
        userinput = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("You've reached the maximum amount of attempts.");
    Console.ReadLine();
    break;
}