using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using Batoot_Movies.Interfaces;
using Batoot_Movies.Models;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Batoot_Movies.Services.MovieGaining;

public class MovieSearchService : IMovieService
{
    private const string TmdbApiKeyFilePath = "tmdb_api.txt";


    public List<Movie>? GetMovies(string name)
    {
        var tmdbMovies = GetMoviesFromTmdb(name);

        // var omdbMovies = await GetMoviesFromOmdbAsync(name);
        return tmdbMovies ?? null;
    }

    private List<Movie>? GetMoviesFromTmdb(string name)
    {
        var options = new RestClientOptions($"https://api.themoviedb.org/3/search/movie?query={name}");
        var client = new RestClient(options);
        var request = new RestRequest("");
        request.AddHeader("accept", "application/json");
        request.AddHeader("Authorization", $"Bearer {File.ReadAllText(TmdbApiKeyFilePath)}");
        var response = client.Get(request);

        if (response.Content != null)
        {
            var movies =  JObject.Parse(response.Content)["results"]?.ToObject<List<Movie>>();
            
            if (movies != null)
                return movies;
        }
        
        return null;
    }

// private async Task<List<Movie>> GetMoviesFromOmdbAsync(string name)
    // {
    //     using var client = new HttpClient();
    //     var url = $"http://www.omdbapi.com/?s={name}&apikey={_omdbApiKey}";
    //     var response = await client.GetStringAsync(url);
    //     var result = JsonSerializer.Deserialize<OmdbResponse>(response);
    //     return result.Search;
    // }
}