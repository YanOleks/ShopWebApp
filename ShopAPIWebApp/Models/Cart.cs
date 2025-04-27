using ShopAPIWebApp.Models.ShopAPIWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace ShopAPIWebApp.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ProductId { get; set; }

        public User? User { get; set; }
        public Product? Product { get; set; }
    }
}
