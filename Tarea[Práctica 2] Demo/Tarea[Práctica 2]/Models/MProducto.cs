using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tarea_Práctica_2_.Models
{
    public class MProducto
    {
        [Key]
        public int idProducto { get; set; }

        [Required]
        [Display(Name = "Nombre del videojuego")]
        public string nombre { get; set; }

        [Display(Name = "Categoria")]
        public int idCategoria { get; set; }

        [Display(Name = "Categoria")]
        [ForeignKey("idCategoria")]
        public virtual MCategoria MCategoria { get; set; }

        [Display(Name = "Consola")]
        public int idConsola { get; set; }

        [Display(Name = "Consola")]
        [ForeignKey("idConsola")]
        public virtual MConsola MConsola { get; set; }
    }
}
