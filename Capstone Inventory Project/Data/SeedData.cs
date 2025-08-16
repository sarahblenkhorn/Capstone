using Capstone_Inventory_Project.Data;
using Capstone_Inventory_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_Inventory_Project.Data;

public static class SeedData
{
    public static async Task EnsureSeedAsync(ApplicationDbContext db)
    {
        await db.Database.MigrateAsync();

        if (!await db.EquipmentRequests.AnyAsync())
        {
            db.EquipmentRequests.AddRange(
                new EquipmentRequest
                {
                    RequesterName = "User Name",
                    Email = "jane@example.com",
                    Department = "Sales",
                    ManagerEmail = "mgr@example.com",
                    EquipmentType = "Laptop",
                    Reason = "Old device failing",
                    Status = "Approved",
                    SubmittedAt = DateTime.UtcNow.AddDays(-3)
                },
                new EquipmentRequest
                {
                    RequesterName = "User Name",
                    Email = "jane@example.com",
                    Department = "Ops",
                    ManagerEmail = "mgr@example.com",
                    EquipmentType = "Monitor",
                    Reason = "Dual monitor setup",
                    Status = "Pending",
                    SubmittedAt = DateTime.UtcNow.AddDays(-1)
                }
            );
            await db.SaveChangesAsync();
        }
    }
}
