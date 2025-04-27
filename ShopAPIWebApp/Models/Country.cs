using ShopAPIWebApp.Models.ShopAPIWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace ShopAPIWebApp.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Product>? Products { get; set; }
    }
}
