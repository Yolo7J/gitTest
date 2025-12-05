using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string UnitType { get; set; } = string.Empty; // Military, Civilian, Support

        [StringLength(50)]
        public string UnitClass { get; set; } = string.Empty; // Melee, Ranged, Cavalry, etc.

        [Range(0, 200)]
        public int CombatStrength { get; set; }

        [Range(0, 200)]
        public int RangedStrength { get; set; }

        [Range(0, 10)]
        public int Range { get; set; }

        [Range(1, 10)]
        public int Movement { get; set; }

        [Range(0, 1000)]
        public int ProductionCost { get; set; }

        [Range(0, 100)]
        public int MaintenanceCost { get; set; }

        [StringLength(50)]
        public string Era { get; set; } = string.Empty;

        [StringLength(200)]
        public string RequiredTechnology { get; set; } = string.Empty;

        [StringLength(200)]
        public string RequiredCivic { get; set; } = string.Empty;

        public bool IsUnique { get; set; }

        public bool CanEmbark { get; set; }

        [StringLength(500)]
        public string SpecialAbilities { get; set; } = string.Empty;
    }
}
