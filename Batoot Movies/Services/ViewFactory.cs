using System.Windows;
using System.Windows.Controls;
using Batoot_Movies.Interfaces;
using Batoot_Movies.Models;
using Batoot_Movies.ViewModels;
using Batoot_Movies.Views;

namespace Batoot_Movies.Services;


public class ViewFactory
{
    public AboutMovieView CreateView(Movie? movie)
    {
        var viewModel = new AboutMovieViewModel(movie);

        var view = new AboutMovieView
        {
            DataContext = viewModel
        };

        return view;
    }
}