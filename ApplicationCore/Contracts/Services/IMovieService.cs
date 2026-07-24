using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    List<MovieCard> Get30HighestGrossingMovies();
}