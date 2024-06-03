using System.Windows;
using Batoot_Movies.ViewModels;
using Batoot_Movies.Views;

namespace Batoot_Movies;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainContentControl.Content = new MainMenu();
    }
    
    public void SetMainContent(AboutMovieView newContent)
    {
        MainContentControl.Content = newContent;
    }
}