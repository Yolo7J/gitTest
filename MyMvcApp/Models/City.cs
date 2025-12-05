using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMvcApp.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Range(1, 999)]
        public int Population { get; set; }

        [Range(0, 200)]
        public int ProductionPerTurn { get; set; }

        [Range(0, 200)]
        public int SciencePerTurn { get; set; }

        [Range(0, 200)]
        public int CulturePerTurn { get; set; }

        [Range(0, 200)]
        public int GoldPerTurn { get; set; }

        [Range(0, 200)]
        public int FaithPerTurn { get; set; }

        [Range(0, 10)]
        public int DistrictCount { get; set; }

        public bool IsCapital { get; set; }

        public bool HasWalls { get; set; }

        [Range(0, 200)]
        public int DefenseStrength { get; set; }

        public DateTime FoundedDate { get; set; }

        [StringLength(50)]
        public string Era { get; set; } = string.Empty;

        // Foreign key
        [ForeignKey("Civilization")]
        public int CivilizationId { get; set; }

        // Navigation property
        public virtual Civilization? Civilization { get; set; }
        public virtual ICollection<Building>? Buildings { get; set; }
    }
}
