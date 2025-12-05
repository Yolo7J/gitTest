using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMvcApp.Models
{
    public class Building
    {
        [Key]
        public int BuildingId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string BuildingType { get; set; } = string.Empty; // District, Building, Wonder

        [Range(0, 2000)]
        public int ProductionCost { get; set; }

        [Range(0, 50)]
        public int MaintenanceCost { get; set; }

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Range(0, 50)]
        public int FoodYield { get; set; }

        [Range(0, 50)]
        public int ProductionYield { get; set; }

        [Range(0, 50)]
        public int GoldYield { get; set; }

        [Range(0, 50)]
        public int ScienceYield { get; set; }

        [Range(0, 50)]
        public int CultureYield { get; set; }

        [Range(0, 50)]
        public int FaithYield { get; set; }

        [StringLength(200)]
        public string RequiredTechnology { get; set; } = string.Empty;

        [StringLength(200)]
        public string RequiredCivic { get; set; } = string.Empty;

        [StringLength(100)]
        public string RequiredDistrict { get; set; } = string.Empty;

        [StringLength(500)]
        public string SpecialAbilities { get; set; } = string.Empty;

        public bool IsUnique { get; set; }

        [StringLength(50)]
        public string Era { get; set; } = string.Empty;

        // Foreign key (optional - can be built in any city)
        [ForeignKey("City")]
        public int? CityId { get; set; }

        // Navigation property
        public virtual City? City { get; set; }
    }
}
