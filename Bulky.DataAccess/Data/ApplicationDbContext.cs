using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "It Ends with Us", 
                    Author = "Colleen Hover",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ISBN = "1471156265",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                   new Product
                {
                    Id = 2,
                    Title = "The Summer I Turned Pretty", 
                    Author = "Jenny Han",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ISBN = "1416968296",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                   new Product
                {
                    Id = 3,
                    Title = "A Good Girl's Guide to Murder", 
                    Author = "Holly Jackson",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ISBN = "9780593568477",
                    ListPrice = 89,
                    Price = 80,
                    Price50 = 75,
                    Price100 = 70,
                    CategoryId = 1,
                    ImageUrl = ""
                   },
                    new Product
                {
                    Id = 4,
                    Title = "Things we never got over", 
                    Author = "Lucy Score",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ISBN = "194563183X ",
                    ListPrice = 69,
                    Price = 60,
                    Price50 = 55,
                    Price100 = 50,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                    new Product
                {
                    Id = 5,
                    Title = "The Seven Husbands of Evelyn Hugo", 
                    Author = "Taylor Jenkins Reid",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ISBN = "1501139231",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                    new Product
                {
                    Id = 6,
                    Title = "Reminders of Him", 
                    Author = "Colleen Hover",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ISBN = "1542025605",
                    ListPrice = 59,
                    Price = 50,
                    Price50 = 45,
                    Price100 = 40,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}
