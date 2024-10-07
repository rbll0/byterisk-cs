using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteRisk_cs.Properties.Domain.Entities
{
    [Table("SINISTRO")]
    public class SinistroEntity
    {
        [Key]
        public int Id { get; set; }

        public int BeneficiarioId { get; set; }
        public BeneficiarioEntity? Beneficiario { get; set; }

        [Required]
        public DateTime DataSinistro { get; set; }

        [StringLength(50)]
        public string? TipoSinistro { get; set; }

        [Required]
        public decimal ValorSinistro { get; set; } // Precisão e escala corrigidas no OnModelCreating
    }
}
