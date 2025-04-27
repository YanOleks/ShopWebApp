namespace ShopAPIWebApp.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace ShopAPIWebApp.Models
    {
        public class Product
        {
            public int Id { get; set; }

            [Required]
            public string Name { get; set; } = string.Empty;

            [Required]
            public int TypeId { get; set; }

            [Required]
            public int CountryId { get; set; }

            public string? Producer { get; set; }

            [Required]
            public decimal Price { get; set; }

            public string? Description { get; set; }

            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

            // Навігаційні властивості
            public ProductType? Type { get; set; }
            public Country? Country { get; set; }
            public ICollection<OrderItem>? OrderItems { get; set; }
            public ICollection<Cart>? Favorites { get; set; }
            public ICollection<Review>? Reviews { get; set; }
        }
    }

}
