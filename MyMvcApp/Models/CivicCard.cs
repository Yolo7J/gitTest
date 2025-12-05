using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class CivicCard
    {
        [Key]
        public int CivicCardId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string Era { get; set; } = string.Empty;

        [Range(0, 5000)]
        public int CultureCost { get; set; }

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [StringLength(200)]
        public string Prerequisites { get; set; } = string.Empty;

        [StringLength(50)]
        public string CardType { get; set; } = string.Empty; // Economic, Military, Diplomatic, Wildcard

        [StringLength(500)]
        public string Effect { get; set; } = string.Empty;

        public bool IsBoostable { get; set; }

        [StringLength(500)]
        public string BoostCondition { get; set; } = string.Empty;

        [Range(0, 100)]
        public int BoostPercentage { get; set; }

        [StringLength(200)]
        public string UnlocksGovernments { get; set; } = string.Empty;

        [StringLength(200)]
        public string UnlocksPolicies { get; set; } = string.Empty;
    }
}
