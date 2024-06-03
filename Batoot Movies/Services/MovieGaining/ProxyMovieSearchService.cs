using Batoot_Movies.Interfaces;
using Batoot_Movies.Models;

namespace Batoot_Movies.Services.MovieGaining;

public class ProxyMovieSearchService : IMovieService
{
    private readonly MovieSearchService _movieService = new();
    private readonly Dictionary<string, List<Movie>> _cache = new();

    public List<Movie>? GetMovies(string name)
    {
        if (_cache.TryGetValue(name, out var oldMovie))
        {
            return oldMovie;
        }
        var movies = _movieService.GetMovies(name);
        if (movies == null)
            return null;
        _cache[name] = movies;
        return movies;
            
    }
}