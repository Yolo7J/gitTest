using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Technology
    {
        [Key]
        public int TechnologyId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string Era { get; set; } = string.Empty;

        [Range(0, 5000)]
        public int ResearchCost { get; set; }

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [StringLength(200)]
        public string Prerequisites { get; set; } = string.Empty;

        [StringLength(300)]
        public string UnlocksUnits { get; set; } = string.Empty;

        [StringLength(300)]
        public string UnlocksBuildings { get; set; } = string.Empty;

        [StringLength(300)]
        public string UnlocksImprovements { get; set; } = string.Empty;

        public bool IsBoostable { get; set; }

        [StringLength(500)]
        public string BoostCondition { get; set; } = string.Empty;

        [Range(0, 100)]
        public int BoostPercentage { get; set; }

        public bool IsLeafTech { get; set; }
    }
}
