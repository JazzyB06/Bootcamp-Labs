string userInput;

int i = 0;
do
{
    Console.WriteLine("Hello World!");
    Console.WriteLine("Would you like to continue 'Y' for 'yes' and 'N' for 'no'.");
    userInput = Console.ReadLine();
    i++;
}
while (i<5);
{
    userInput = Console.ReadLine();
    Console.WriteLine("Goodbye!");
}