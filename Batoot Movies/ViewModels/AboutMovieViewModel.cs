using Batoot_Movies.Interfaces;
using Batoot_Movies.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Batoot_Movies.ViewModels;

public partial class AboutMovieViewModel : ObservableObject
{
    [ObservableProperty] private Movie? _movie;

    public AboutMovieViewModel(Movie? movie)
    {
        _movie = movie;
    }
    
    public AboutMovieViewModel() { }
}