using ShopAPIWebApp.Models.ShopAPIWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace ShopAPIWebApp.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        // Навігаційні властивості
        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}
