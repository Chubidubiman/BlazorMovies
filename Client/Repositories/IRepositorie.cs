using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repositories
{
    public interface IRepositorie
    {
        List<Movie> GetMovies();
    }
}