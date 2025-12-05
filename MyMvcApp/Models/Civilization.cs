using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Civilization
    {
        [Key]
        public int CivilizationId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string UniqueAbility { get; set; } = string.Empty;

        [StringLength(50)]
        public string PrimaryColor { get; set; } = string.Empty;

        [StringLength(50)]
        public string SecondaryColor { get; set; } = string.Empty;

        [StringLength(100)]
        public string StartingBias { get; set; } = string.Empty;

        [StringLength(100)]
        public string UniqueUnit { get; set; } = string.Empty;

        [StringLength(100)]
        public string UniqueInfrastructure { get; set; } = string.Empty;

        public bool IsExpansion { get; set; }

        // Navigation property
        public virtual ICollection<Leader>? Leaders { get; set; }
    }
}
