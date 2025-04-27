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
        [MaxLength(50)]
        public string Role { get; set; } = "buyer";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Навігаційні властивості
        public ICollection<Order>? Orders { get; set; }
        public ICollection<Cart>? Favorites { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
