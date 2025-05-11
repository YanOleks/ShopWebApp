using System.ComponentModel.DataAnnotations;

namespace ShopAPIWebApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public string? Name { get; set; }

        [Required]
        public UserRole Role { get; set; } = UserRole.Buyer;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Order>? Orders { get; set; }
        public ICollection<Cart>? Favorites { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }

    public enum UserRole
    {
        Buyer = 0,
        Admin = 1
    }
}
