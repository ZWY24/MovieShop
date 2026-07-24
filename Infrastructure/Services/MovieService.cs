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

    public MovieDetailModel GetMovieDetails(int id)
    {
        var movie = _movieRepository.GetById(id);

        var movieDetails = new MovieDetailModel
        {
            Id = movie.Id,
            Title = movie.Title,
            Overview = movie.Overview,
            Tagline = movie.Tagline,
            Budget = movie.Budget,
            Revenue = movie.Revenue,
            ImdbUrl = movie.ImdbUrl,
            TmdbUrl = movie.TmdbUrl,
            PosterUrl = movie.PosterUrl,
           BackdropUrl = movie.BackdropUrl,
            OriginalLanguage = movie.OriginalLanguage,
           ReleaseDate = movie.ReleaseDate,
            RunTime = movie.RunTime,
           Price = movie.Price,
           Rating = movie.Rating
        };

       foreach (var trailer in movie.Trailers)
        {
            movieDetails.Trailers.Add(new TrailerModel
            {
                Id = trailer.Id,
                Name = trailer.Name,
                TrailerUrl = trailer.TrailerUrl
            });
        }

        foreach (var mg in movie.GenresOfMovie)
        {
            movieDetails.Genres.Add(new GenreModel
            {
                Id = mg.Genre.Id,
                Name = mg.Genre.Name
            });
        }

        foreach (var mc in movie.MovieCasts)
        {
            movieDetails.Casts.Add(new CastModel
            {
                Id = mc.Cast.Id,
                Name = mc.Cast.Name,
                ProfilePath = mc.Cast.ProfilePath,
                Character = mc.Character
            });
        }

        return movieDetails;
    }

}