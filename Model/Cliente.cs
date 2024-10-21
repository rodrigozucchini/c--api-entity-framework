using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Model;
public class Cliente {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [MaxLength(20)]
    [Column("Nombre", TypeName = "varchar")]
    public string? Nombre { get; set; }
    
    [MaxLength(30)]
    [Column("Apellido", TypeName="varchar")]
    public string? Apellido { get; set; }
    
    [MaxLength(15)]
    [Column("Telefono", TypeName="varchar")]
    public string? Telefono { get; set; }
    
    [MaxLength(50)]
    [Column("Email", TypeName="varchar")]
    public string? Email { get; set; }
    
    [Column("FechaNacimiento", TypeName ="datetime")]
    public DateTime? FechaNacimiento { get; set; }
    
    [Column("Salario", TypeName = "decimal")]
    public decimal? Salario { get; set; }
}