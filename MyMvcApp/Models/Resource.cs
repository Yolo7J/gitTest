using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string ResourceType { get; set; } = string.Empty; // Bonus, Luxury, Strategic

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Range(0, 10)]
        public int FoodYield { get; set; }

        [Range(0, 10)]
        public int ProductionYield { get; set; }

        [Range(0, 10)]
        public int GoldYield { get; set; }

        [Range(0, 10)]
        public int ScienceYield { get; set; }

        [Range(0, 10)]
        public int CultureYield { get; set; }

        [Range(0, 10)]
        public int FaithYield { get; set; }

        [StringLength(200)]
        public string ImprovedBy { get; set; } = string.Empty;

        [StringLength(200)]
        public string RequiredTechnology { get; set; } = string.Empty;

        [StringLength(300)]
        public string ValidTerrain { get; set; } = string.Empty;

        public bool ProvidesAmenity { get; set; }

        [Range(0, 6)]
        public int AmenityValue { get; set; }

        [Range(0, 1000)]
        public int AccumulationRate { get; set; }

        [StringLength(500)]
        public string UsedFor { get; set; } = string.Empty;

        public bool IsHarvestable { get; set; }
    }
}
