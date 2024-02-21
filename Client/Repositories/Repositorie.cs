using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repositories
{
    public class Repositorie : IRepositorie
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie{Title = "Wakawaka Pa Siempre", LaunchDate = new DateTime(2024, 1, 30)},
                new Movie{Title = "Monana", LaunchDate = new DateTime(2016, 11, 23)},
                new Movie{Title = "Paprika", LaunchDate = new DateTime(2010, 7, 16)}
            };
        }
    }
}