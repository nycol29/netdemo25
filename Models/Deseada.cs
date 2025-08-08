using System.ComponentModel.DataAnnotations;

namespace netdemo.Models
{
    public class Deseada
    {
        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        [Display(Name = "Año")]
        public int Año { get; set; }

        [Required]
        public string Categoria { get; set; }
    }
}
