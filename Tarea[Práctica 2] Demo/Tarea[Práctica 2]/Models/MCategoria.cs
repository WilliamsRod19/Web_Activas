using System.ComponentModel.DataAnnotations;

namespace Tarea_Práctica_2_.Models
{
    public class MCategoria
    {
        [Key]
        public int idCategoria { get; set; }

        [Required]
        [Display(Name = "Nombre de la categoria")]
        public string nombre { get; set; }
    }
}
