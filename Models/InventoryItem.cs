using System;
using System.ComponentModel.DataAnnotations;

namespace Capstone_Inventory_Project.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string EquipmentType { get; set; } = "";

        [StringLength(120)]
        public string? Model { get; set; }

        [StringLength(120)]
        public string? SerialNumber { get; set; }

        [Required, StringLength(30)]
        public string Status { get; set; } = "Available";

        [StringLength(200)]
        public string? AssignedTo { get; set; }
        public int? AssignedRequestId { get; set; }
        public DateTime? AssignedAt { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
