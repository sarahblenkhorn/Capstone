using Capstone_Inventory_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_Inventory_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EquipmentRequest> EquipmentRequests => Set<EquipmentRequest>();
    }
}
