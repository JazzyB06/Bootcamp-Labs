
//The code below calculates the sum of numbers from 1 to 500 using a for loop. It initializes a variable 'sum' to 0, then iterates through
//numbers 1 to 500, adding each number to the 'sum'. Lastly, it displays the calculated sum using the Console.WriteLine() function. 

int sum = 0; 
for (int i = 1; i <= 500; i++)
{
    sum += i;
}
Console.WriteLine($"The sum of numbers from 1 to 500 is: {sum}");
