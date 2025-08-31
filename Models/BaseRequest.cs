using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capstone_Inventory_Project.Models
{
    public abstract class BaseRequest
    {
        public int Id { get; set; }

        [Required]
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        [Required, StringLength(40)]
        public string Status { get; set; } = "Pending";

        [NotMapped] public virtual string Category => "General";

        [NotMapped] public virtual string DisplayKey => $"{Id}-{SubmittedAt:yyyyMMdd}";
    }
}

