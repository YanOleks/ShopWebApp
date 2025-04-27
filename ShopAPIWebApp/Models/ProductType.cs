using ShopAPIWebApp.Models.ShopAPIWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace ShopAPIWebApp.Models
{
    public class ProductType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        // Навігаційна властивість
        public ICollection<Product>? Products { get; set; }
    }
}
