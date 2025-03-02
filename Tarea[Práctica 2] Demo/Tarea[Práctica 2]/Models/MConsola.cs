using System.ComponentModel.DataAnnotations;

namespace Tarea_Práctica_2_.Models
{
    public class MConsola
    {
        [Key]
        public int idConsola { get; set; }

        [Required]
        [Display(Name = "Nombre de la consola")]
        public string nombre { get; set; }
    }
}
