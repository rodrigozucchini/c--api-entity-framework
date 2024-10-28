using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Model
{
    public class Producto 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [MaxLength(30)]
        [Column("Descripcion", TypeName = "varchar")]
        public string? Descripcion { get; set; }
        
        [MaxLength(15)]
        [Column("Rubro", TypeName = "varchar")]
        public string? Rubro { get; set; }
        
        [Column("FechaVencimiento", TypeName = "datetime")]
        public DateTime? FechaVencimiento { get; set; }
        
        [Column("PrecioBase", TypeName = "decimal(18,2)")]
        public decimal PrecioBase { get; set; }
        
        [Column("Impuesto", TypeName = "decimal(18,2)")]
        public decimal Impuesto { get; set; }
        
        [Column("Stock", TypeName = "decimal(18,2)")]
        public decimal Stock { get; set; }
        
        [Column("StockMinimo", TypeName = "decimal(18,2)")]
        public decimal StockMinimo { get; set; }
    }
}