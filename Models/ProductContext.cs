using Microsoft.EntityFrameworkCore;

namespace TermProject.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Season> Seasons { get; set; } = null!;
        public DbSet<Designer> Designers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Designer>().HasData(
                new Designer { DesignerId = 1, Name = "Elia Schall"},
                new Designer { DesignerId = 2, Name = "Romy Linder"},
                new Designer { DesignerId = 3, Name = "Hugo Karlen"},
                new Designer { DesignerId = 4, Name = "Elinora Felix"},
                new Designer { DesignerId = 5, Name = "Tessa Abeline" });

            modelBuilder.Entity<Season>().HasData(
                new Season { SeasonId = "S", Name = "Spring/Summer" },
                new Season { SeasonId = "F", Name = "Fall/Winter" });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    DesignerId = 3,
                    Name = "Caviar Dreams Asymmetrical",
                    Type = "Skirt",
                    Year = 2022,
                    SeasonId = "S"
                },
                new Product
                {
                    ProductId = 2,
                    DesignerId = 2,
                    Name = "Effervescent Halter Wrap",
                    Type = "Top",
                    Year = 2022,
                    SeasonId = "F"      
                },
                new Product
                {
                    ProductId = 3,
                    DesignerId = 5,
                    Name = "Nephilim Winged Bomber",
                    Type = "Jacket",
                    Year = 2023,
                    SeasonId = "F"
                },
                new Product
                {
                    ProductId = 4,
                    DesignerId = 1,
                    Name = "Counterculture Bootcut",
                    Type = "Pants",
                    Year = 2024,
                    SeasonId = "S"
                });
        }
    }
}
