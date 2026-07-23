using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class MovieService : IMovieService
{
    public List<MovieCard> GetTopRevenueMovies()
    {
        return new List<MovieCard>
        {
            new MovieCard { Id = 1, Title = "Inception", PosterUrl = "https://image.tmdb.org/t/p/w342/9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg" },
            new MovieCard { Id = 2, Title = "Interstellar", PosterUrl = "https://image.tmdb.org/t/p/w342/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg" },
            new MovieCard { Id = 3, Title = "The Dark Knight", PosterUrl = "https://image.tmdb.org/t/p/w342/qJ2tW6WMUDux911r6m7haRef0WH.jpg" },
            new MovieCard { Id = 4, Title = "Deadpool", PosterUrl = "https://image.tmdb.org/t/p/w342/yGSxMiF0cYuAiyuve5DA6bnWnBm.jpg" },
            new MovieCard { Id = 5, Title = "The Avengers", PosterUrl = "https://image.tmdb.org/t/p/w342/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg" }
        };
    }

    public List<MovieCard> Get30HighestGrossingMovies()
    {
        var movies = new List<MovieCard> {
            new MovieCard { Id = 1, Title = "Inception", PosterUrl = "https://image.tmdb.org/t/p/w342/9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg" },
            new MovieCard { Id = 2, Title = "Interstellar", PosterUrl = "https://image.tmdb.org/t/p/w342/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg" },
            new MovieCard { Id = 3, Title = "The Dark Knight", PosterUrl = "https://image.tmdb.org/t/p/w342/qJ2tW6WMUDux911r6m7haRef0WH.jpg" },
            new MovieCard { Id = 4, Title = "Deadpool", PosterUrl = "https://image.tmdb.org/t/p/w342/yGSxMiF0cYuAiyuve5DA6bnWnBm.jpg" },
            new MovieCard { Id = 5, Title = "The Avengers", PosterUrl = "https://image.tmdb.org/t/p/w342/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg" }
        };
        return movies;
    }
}