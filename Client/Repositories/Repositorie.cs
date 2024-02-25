using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repositories
{
    public class Repositorie : IRepositorie
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie{Title = "Wakawaka Pa Siempre", 
                    LaunchDate = new DateTime(2024, 1, 30),
                    Poster = "https://upload.wikimedia.org/wikipedia/en/3/3b/Black_Panther_Wakanda_Forever_poster.jpg"
                    },
                new Movie{Title = "Monana", 
                    LaunchDate = new DateTime(2016, 11, 23),
                    Poster = "https://upload.wikimedia.org/wikipedia/en/2/26/Moana_Teaser_Poster.jpg"
                    },
                new Movie{Title = "Paprika", 
                    LaunchDate = new DateTime(2010, 7, 16),
                    Poster = "https://upload.wikimedia.org/wikipedia/en/1/16/Paprikaposter.jpg"
                    }
            };
        }
    }
}