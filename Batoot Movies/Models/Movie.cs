using CommunityToolkit.Mvvm.ComponentModel;

namespace Batoot_Movies.Models;

public class Movie
{
    public bool Adult { get; set; }
    public string Backdrop_path { get; set; }
    public List<int> GenreIds { get; set; }
    public int Id { get; set; }
    public string Original_language { get; set; }
    public string Original_title { get; set; }
    public string Overview { get; set; }
    public double Popularity { get; set; }
    public string Poster_path { get; set; }
    public string Release_date { get; set; }
    public string Title { get; set; }
    public bool Video { get; set; }
    public double Vote_average { get; set; }
    public int Vote_count { get; set; }
    public string FullPosterPath => $"https://image.tmdb.org/t/p/w500{Poster_path}";
    public string FullBackdropPath => $"https://image.tmdb.org/t/p/w500{Backdrop_path}";
}
