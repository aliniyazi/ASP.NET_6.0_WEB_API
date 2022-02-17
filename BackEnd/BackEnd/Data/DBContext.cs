using BackEnd.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options):base(options)
        {

        }
        public DbSet<Chef>? Chefs { get; set; }
        public DbSet<Dish>? Dishes { get; set; }
        public DbSet<ChefDish>? ChefDishes { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Rating>? Ratings { get; set; }
        public DbSet<User>? Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChefDish>(entity => 
            {
                entity.HasKey(cd => new { cd.ChefId, cd.DishId });

                entity.HasOne(cd=>cd.Chef).WithMany(c=>c.Chefdishes).HasForeignKey(cd=>cd.ChefId);
                entity.HasOne(cd => cd.Dish).WithMany(d => d.ChefDishes).HasForeignKey(cd => cd.DishId);
                entity.HasMany(cd => cd.Rating).WithOne(r => r.ChefDish).HasForeignKey(r => new { r.ChefId, r.DishId });
                
            });
            modelBuilder.Entity<Chef>(entity =>
            {
                entity.HasOne(c => c.Address).WithMany(a => a.Chefs).HasForeignKey(c => c.AddressId);
            });
            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasOne(r => r.User).WithMany(u => u.Ratings).HasForeignKey(r => r.UserId);
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasOne(u => u.Address).WithMany(a => a.Users).HasForeignKey(u => u.AddressId);
            });
        }
    }
}
