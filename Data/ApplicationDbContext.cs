using Capstone_Inventory_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_Inventory_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<EquipmentRequest> EquipmentRequests => Set<EquipmentRequest>();
        public DbSet<InventoryItem> InventoryItems => Set<InventoryItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EquipmentRequest>()
                        .HasIndex(e => new { e.Email, e.SubmittedAt });

            modelBuilder.Entity<InventoryItem>()
                        .HasIndex(i => new { i.EquipmentType, i.Status });
        }
    }
}
