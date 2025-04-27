using System.ComponentModel.DataAnnotations;

namespace ShopAPIWebApp.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int StatusId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Навігаційні властивості
        public User? User { get; set; }
        public OrderStatus? Status { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
