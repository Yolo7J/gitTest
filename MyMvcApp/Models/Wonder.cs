using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Wonder
    {
        [Key]
        public int WonderId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string Era { get; set; } = string.Empty;

        [Range(0, 5000)]
        public int ProductionCost { get; set; }

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [StringLength(500)]
        public string Effect { get; set; } = string.Empty;

        [StringLength(200)]
        public string RequiredTechnology { get; set; } = string.Empty;

        [StringLength(200)]
        public string RequiredCivic { get; set; } = string.Empty;

        [StringLength(100)]
        public string RequiredTerrain { get; set; } = string.Empty;

        [Range(0, 20)]
        public int GreatPersonPoints { get; set; }

        [StringLength(50)]
        public string GreatPersonType { get; set; } = string.Empty;

        public bool IsNaturalWonder { get; set; }

        public bool IsObsolete { get; set; }

        [StringLength(200)]
        public string ObsoleteEra { get; set; } = string.Empty;

        [Range(0, 50)]
        public int TourismYield { get; set; }

        [StringLength(500)]
        public string PlacementRequirements { get; set; } = string.Empty;

        public bool IsBuildable { get; set; } = true;
    }
}
