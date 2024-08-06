using MovieLab.Models;

namespace MovieLab.Services
{
    public class OMDBService : IOMDBService
    {
        //make a method that call the api
        //and returns the C# objects from the json
        public async Task <OMDBResponse> SearchMovies(string movieName)
        {
            //create the url as a string with all the info in it
            string url = $"http://www.omdbapi.com/?apikey=16efb775&s={movieName}";
            //call the api and get a response
            using (HttpClient client  = new HttpClient())
            {
                try
                {
                    OMDBResponse response = await client.GetFromJsonAsync<OMDBResponse>(url);

                    return response;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            //if the response is good, return the movies

            //if the response is not good write a log
        }
    }
}
