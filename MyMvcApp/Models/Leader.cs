using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMvcApp.Models
{
    public class Leader
    {
        [Key]
        public int LeaderId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string LeaderAbility { get; set; } = string.Empty;

        [StringLength(200)]
        public string Agenda { get; set; } = string.Empty;

        [StringLength(1000)]
        public string AgendaDescription { get; set; } = string.Empty;

        [StringLength(100)]
        public string UniqueUnit { get; set; } = string.Empty;

        [StringLength(100)]
        public string UniqueBuilding { get; set; } = string.Empty;

        [Range(1, 10)]
        public int LeaderDifficulty { get; set; }

        public bool IsAlternate { get; set; }

        // Foreign key
        [ForeignKey("Civilization")]
        public int CivilizationId { get; set; }

        // Navigation property
        public virtual Civilization? Civilization { get; set; }
    }
}
