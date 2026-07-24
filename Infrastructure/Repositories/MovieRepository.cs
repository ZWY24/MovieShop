using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class MovieRepository : Repository<Movie>, IMovieRepository
{
    public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
    {
    }

    public IEnumerable<Movie> GetTop30HighestGrossingMovies()
    {
        return _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToList();
    }

    public IEnumerable<Movie> GetTop30HighestRatedMovies()
    {
        return _dbContext.Movies.OrderByDescending(m => m.Rating).Take(30).ToList();
    }
}