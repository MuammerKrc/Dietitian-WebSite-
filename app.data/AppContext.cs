using app.data.Configuration;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<Pilates> Pilateis { get; set; }
        public DbSet<DietWekkly> DietWekklies { get; set; }
        public DbSet<DietMenü> DietMenüs { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CombineDietMenüRecipeConfiguration());
            modelBuilder.ApplyConfiguration(new CombineDietRecipeConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new DietConfiguration());
            modelBuilder.ApplyConfiguration(new DietMenüConfiguration());
            modelBuilder.ApplyConfiguration(new DietWekklyConfiguration());
            modelBuilder.ApplyConfiguration(new RecipeConfiguration());
            modelBuilder.ApplyConfiguration(new PilatesConfiguration());
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=DESKTOP-GJ86AIN\\SQLEXPRESS;Database=appSinem;integrated security=SSPI;");
        // }
    }
}