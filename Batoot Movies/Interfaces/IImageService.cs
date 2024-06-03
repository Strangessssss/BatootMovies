using System.Windows.Media.Imaging;

namespace Batoot_Movies.Interfaces;

public interface IImageService
{
    Task<BitmapImage> GetImageAsync(string url);
}
