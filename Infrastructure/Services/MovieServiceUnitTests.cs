using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class MovieServiceUnitTests : IMovieService
{
    public List<MovieCard> GetTopRevenueMovies()
    {
        var movies = new List<MovieCard>
        {
            new MovieCard { Title = "Inception", Id = 1 },
            new MovieCard { Title = "Interstellar", Id = 2 },
            new MovieCard { Title = "The Dark Knight", Id = 3 },
            new MovieCard { Title = "Deadpool", Id = 4 },
            new MovieCard { Title = "The Avengers", Id = 5 }
        };

        return movies;
    }

    public List<MovieCard> Get30HighestGrossingMovies()
    {
        var movies = new List<MovieCard>
        {
            new MovieCard { Title = "Inception", Id = 11 },
            new MovieCard { Title = "Interstellar", Id = 22 },
            new MovieCard { Title = "The Dark Knight", Id = 33 },
            new MovieCard { Title = "Deadpool", Id = 44 },
            new MovieCard { Title = "The Avengers", Id = 55 }
        };

        return movies;
    }
}