using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Terrain
    {
        [Key]
        public int TerrainId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string TerrainType { get; set; } = string.Empty; // Plains, Grassland, Desert, Tundra, Snow

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Range(0, 10)]
        public int FoodYield { get; set; }

        [Range(0, 10)]
        public int ProductionYield { get; set; }

        [Range(0, 10)]
        public int GoldYield { get; set; }

        [Range(1, 10)]
        public int MovementCost { get; set; }

        [Range(0, 10)]
        public int DefenseBonus { get; set; }

        public bool IsWater { get; set; }

        public bool IsImpassable { get; set; }

        [StringLength(200)]
        public string Features { get; set; } = string.Empty; // Forest, Jungle, Marsh, etc.

        [Range(0, 5)]
        public int AppealModifier { get; set; }

        [StringLength(300)]
        public string ValidResources { get; set; } = string.Empty;

        [StringLength(300)]
        public string ValidImprovements { get; set; } = string.Empty;

        public bool ProvidesWater { get; set; }

        [StringLength(200)]
        public string ClimateZone { get; set; } = string.Empty;
    }
}
