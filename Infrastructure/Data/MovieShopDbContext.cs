using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class MovieShopDbContext : DbContext
{
    public DbSet<Genre> Genres { get; set; }

    public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options) : base(options)
    {
    }
}