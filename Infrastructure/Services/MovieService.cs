using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using ApplicationCore.Contracts.Repositories;

namespace Infrastructure.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public List<MovieCard> Get30HighestGrossingMovies()
    {
        var movies = _movieRepository.GetTop30HighestGrossingMovies();
        var movieCards = new List<MovieCard>();

        foreach (var movie in movies)
        {
            movieCards.Add(new MovieCard
            {
                Id = movie.Id,
                Title = movie.Title,
                PosterUrl = movie.PosterUrl
            });
        }

        return movieCards;
    }
}