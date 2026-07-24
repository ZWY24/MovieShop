namespace ApplicationCore.Entities;

public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Email { get; set; }
    public string? HashedPassword { get; set; }
    public string? Salt { get; set; }
    public string? PhoneNumber { get; set; }
    public bool? TwoFactorEnabled { get; set; }
    public DateTime? LockoutEndDate { get; set; }
    public DateTime? LastLoginDateTime { get; set; }
    public bool? IsLocked { get; set; }
    public int? AccessFailedCount { get; set; }

    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}