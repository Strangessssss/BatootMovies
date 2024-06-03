using Batoot_Movies.Models;

namespace Batoot_Movies.Interfaces;

public interface IMovieService
{
    List<Movie>? GetMovies(string name);
}