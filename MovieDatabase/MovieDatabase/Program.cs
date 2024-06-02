using MovieDatabase;
using System.Collections;
using System.Runtime.CompilerServices;
//First way
//List<Movie>movieList  = new List<Movie>();

//instantiation
//Movie movie1 = new Movie("Fast and the Furious 12", "Action");
//movieList.Add(movie1);

//Little fancier
Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("There are 10 movies in this list.");
Console.WriteLine($"What category are you interested in?");
string input = Console.ReadLine();


List<Movie> movieList = new List<Movie>()
{
    new Movie("Enter the Dragon", "Martial Arts"),
    new Movie ("Casablanca", "Classics"),
    new Movie ("Rashomon", "Mystery"),
    new Movie ("West Side Story", "Musical"),
    new Movie ("The Notebook", "Romance"),
    new Movie ("Imaginary", "Mystery"),
    new Movie ("Boyz n the Hood", "Crime"),
    new Movie ("Night Swim", "Thriller"),
    new Movie ("Love Jones", "Romance"),
    new Movie ("American Fiction", "Drama")
    
};
//Print out movies that match that category
searchMovie(Movie,"Mystery");

static void searchMovie(string category)
{
    foreach (var movies in Movie)
    {
        if (movies.Category.Equals(category))
        {
            Console.WriteLine("Title: {0}, Category: {1}", movies.Title, movies.Category);
        }
    }

}
Console.WriteLine("Would you like to continue? (yes/no)");
Console.WriteLine();
Console.WriteLine("Thank you. Goodbye.");