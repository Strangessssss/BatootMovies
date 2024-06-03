using System.Collections.ObjectModel;
using Batoot_Movies.Interfaces;
using Batoot_Movies.Models;
using Batoot_Movies.Services.MovieGaining;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Batoot_Movies.ViewModels;

public partial class MainMenuViewModel : ObservableObject
{

    private readonly ProxyMovieSearchService _movieSearchService = new();
    
    [ObservableProperty] private ObservableCollection<Movie>? _movies;
    [ObservableProperty] private string? _movieSearch;
    
    [RelayCommand]
    private void Search()
    {
        if (string.IsNullOrEmpty(MovieSearch))
            return;
        var found = _movieSearchService.GetMovies(MovieSearch);
        if (found == null)
            return;
        
        Movies = [];
        foreach (var movie in found)
        {
            Movies.Add(movie);
        }
            
    }
}