using System.Windows;
using System.Windows.Controls;
using Batoot_Movies.Interfaces;
using Batoot_Movies.Models;
using Batoot_Movies.Services;
using Batoot_Movies.ViewModels;

namespace Batoot_Movies.Views;

public partial class MainMenu : UserControl
{
    private readonly ViewFactory _factory;
    public MainMenu()
    {
        InitializeComponent();
        _factory = new ViewFactory();
    }

    private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var view = _factory.CreateView(e.AddedItems[0] as Movie);
        var currentMainWindow = Application.Current.MainWindow as MainWindow;
        currentMainWindow?.SetMainContent(view);
    }
}