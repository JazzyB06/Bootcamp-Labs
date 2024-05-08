int KeyCode = 0;

while (KeyCode != 13579)
{
    Console.WriteLine("Kindly, enter your Key Code, please.");
    KeyCode = int.Parse(Console.ReadLine());

    if (KeyCode == 13579)
    {
        Console.WriteLine("It's good to be home! Hello, Jasmine!");
    }
}   