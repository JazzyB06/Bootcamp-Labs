

Console.WriteLine("Welcome! Which student would you like to learn more about? Enter a number 1-9");
string userInput = Console.ReadLine();
int num = int.Parse(userInput);
Console.WriteLine($"You've entered the number {num}");
Console.ReadLine();
Console.WriteLine("Would you like to learn about another student? Enter \"y\" or \"n\":");
Console.ReadLine();
Console.WriteLine("Please continue. Thanks!");
Console.ReadLine();
Console.WriteLine("The student's information is displayed below: ");
userInput = Console.ReadLine();
string[] Studentname = new string[10];
    Studentname[0] = "Anthony";
    Studentname[1] = "Sara";
    Studentname[2] = "John";
    Studentname[3] = "Mark";
    Studentname[5] = "Yvette";
    Studentname[6] = "Henry";
    Studentname[7] = "Eugene";
    Studentname[8] = "Debbie";
    Studentname[9] = "Anne";
    Console.WriteLine(Studentname.Length);
for (int i = 0; i < Studentname.Length; i++)
{
    Console.WriteLine(Studentname[i]);
}

string[] hometown = new string[10]; 
    hometown[0] = "Detroit";
    hometown[1] = "Farmington";
    hometown[2] = "Southfield";
    hometown[3] = "Taylor";
    hometown[4] = "Troy";
    hometown[5] = "Royal Oak";
    hometown[6] = "Grand Rapids";
    hometown[7] = "Lansing";
    hometown[8] = "Highland Park";
    hometown[9] = "Allen Park";
Console.WriteLine(hometown.Length);

for (int i = 0; i < hometown.Length; i++)
{
    Console.WriteLine(hometown[i]);
}

string[] favoritefood = new string[10];
favoritefood[0] = "Bagels";
favoritefood[1] = "Spaghetti";
favoritefood[2] = "Chicken";
favoritefood[3] = "Cake";
favoritefood[4] = "Pie";
favoritefood[5] = "Pasta";
favoritefood[6] = "Sandwich";
favoritefood[7] = "Nachos";
favoritefood[8] = "Pizza";
favoritefood[9] = "Fries";
Console.WriteLine(favoritefood.Length);

for (int i = 0; i < favoritefood.Length; i++)
{
    Console.WriteLine(favoritefood[i]);
}
Console.WriteLine($"This is the student's name {Studentname}, {userInput}");
Console.WriteLine(Studentname[0]);
Console.WriteLine(Studentname[1]);
Console.WriteLine(Studentname[2]);
Console.WriteLine(Studentname[3]);
Console.WriteLine(Studentname[4]);
Console.WriteLine(Studentname[5]);
Console.WriteLine(Studentname[6]);
Console.WriteLine(Studentname[7]);
Console.WriteLine(Studentname[8]);
Console.WriteLine(Studentname[9]);

Console.WriteLine($"This is student's hometown {hometown}, {userInput}");
Console.WriteLine(hometown[0]);
Console.WriteLine(hometown[1]);
Console.WriteLine(hometown[2]);
Console.WriteLine(hometown[3]);
Console.WriteLine(hometown[4]);
Console.WriteLine(hometown[5]);
Console.WriteLine(hometown[6]);
Console.WriteLine(hometown[7]);
Console.WriteLine(hometown[8]);
Console.WriteLine(hometown[9]);
Console.WriteLine(hometown.Length);

Console.WriteLine($"This is the student's favorite food {favoritefood}, {userInput}");
Console.WriteLine(favoritefood[0]);
Console.WriteLine(favoritefood[1]);
Console.WriteLine(favoritefood[2]);
Console.WriteLine(favoritefood[3]);
Console.WriteLine(favoritefood[4]);
Console.WriteLine(favoritefood[5]);
Console.WriteLine(favoritefood[6]);
Console.WriteLine(favoritefood[7]);
Console.WriteLine(favoritefood[8]);
Console.WriteLine(favoritefood[9]);
Console.WriteLine(favoritefood.Length);


try
{
    int[] myNumbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    Console.WriteLine("Only numbers are acceptable.");
}
catch (Exception e)
{
    Console.WriteLine("Something went wrong! Please try again!"); //error handling message
    Console.WriteLine(e.ToString());
}

for(int i = 0; i < Studentname.Length; i++)
{
    Console.WriteLine(Studentname[i]);
}
bool found = false;
object[] array = Studentname.ToArray();

if (Studentname.Length != array.Length)
{
    Console.WriteLine("We found the student!");
    found = true;
}

if (!found)
{
    Console.WriteLine("Student not found: ...");
}

for (int i = 0; i < hometown.Length; i++)
{
    Console.WriteLine(hometown[i]);
}

bool _ = false;
array = favoritefood.ToArray();

if (favoritefood.Length != array.Length)
{
    Console.WriteLine("We found the student's favorite food!");
    found = true;
}
if (!found)
{
    Console.WriteLine("Favorite food can't be found: ...");
}


array = hometown.ToArray();
if (hometown.Length != array.Length)
{
    Console.WriteLine("We found the student's hometown!");
    found = true;
}
if (!found)
{
    Console.WriteLine("Student's hometown not found: ...");
}

