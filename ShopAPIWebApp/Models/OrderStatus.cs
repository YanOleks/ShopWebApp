using System.ComponentModel.DataAnnotations;

namespace ShopAPIWebApp.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Order>? Orders { get; set; }
    }
}
