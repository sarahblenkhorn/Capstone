using System;
using System.ComponentModel.DataAnnotations;

namespace Capstone_Inventory_Project.Models
{
    public class EquipmentRequest : BaseRequest
    {
        [Required, StringLength(80)]
        public string RequesterName { get; set; } = "";

        [Required, EmailAddress, StringLength(120)]
        public string Email { get; set; } = "";

        [StringLength(80)]
        public string Department { get; set; } = "";

        [EmailAddress, StringLength(120)]
        public string ManagerEmail { get; set; } = "";

        [Required, StringLength(40)]
        public string EquipmentType { get; set; } = "";

        [StringLength(120)]
        public string? EquipmentModel { get; set; }

        [StringLength(120)]
        public string? EquipmentSerial { get; set; }

        [StringLength(400)]
        public string? Reason { get; set; }

        public bool IsClosed { get; set; } = false;
        public DateTime? ClosedAt { get; set; }
        public string? CloseNote { get; set; }

        public override string Category => "Equipment";
        public override string DisplayKey => $"{EquipmentType}-{base.DisplayKey}";
    }
}
