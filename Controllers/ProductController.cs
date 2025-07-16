using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyWebApp.Controllers
{
    public class ProductController : Controller
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public decimal Price { get; set; }
            public int Rating { get; set; }
            public int Reviews { get; set; }
        }

        private static readonly List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Wireless Headphones", Description = "High-quality sound, noise-cancelling.", ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?auto=format&fit=crop&w=400&q=80", Price = 29.99m, Rating = 4, Reviews = 120 },
            new Product { Id = 2, Name = "Smart Watch", Description = "Track your fitness and notifications.", ImageUrl = "https://images.unsplash.com/photo-1519125323398-675f0ddb6308?auto=format&fit=crop&w=400&q=80", Price = 49.99m, Rating = 5, Reviews = 89 },
            new Product { Id = 3, Name = "Running Shoes", Description = "Comfortable and lightweight for daily runs.", ImageUrl = "https://images.unsplash.com/photo-1512436991641-6745cdb1723f?auto=format&fit=crop&w=400&q=80", Price = 19.99m, Rating = 3, Reviews = 45 },
            new Product { Id = 4, Name = "Bluetooth Speaker", Description = "Portable, waterproof, and powerful sound.", ImageUrl = "https://images.unsplash.com/photo-1518445697755-0b1c1e2b7a2b?auto=format&fit=crop&w=400&q=80", Price = 34.99m, Rating = 5, Reviews = 67 },
            new Product { Id = 5, Name = "Leather Wallet", Description = "Premium leather, slim design.", ImageUrl = "https://images.unsplash.com/photo-1515378791036-0648a3ef77b2?auto=format&fit=crop&w=400&q=80", Price = 24.99m, Rating = 4, Reviews = 32 },
            new Product { Id = 6, Name = "Sunglasses", Description = "UV protection, stylish design.", ImageUrl = "https://images.unsplash.com/photo-1503342217505-b0a15ec3261c?auto=format&fit=crop&w=400&q=80", Price = 14.99m, Rating = 5, Reviews = 150 }
        };

        public IActionResult Details(int id)
        {
            var product = Products.Find(p => p.Id == id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
} 