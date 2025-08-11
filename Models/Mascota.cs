using System.ComponentModel.DataAnnotations;

namespace netdemo.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
public string Nombre { get; set; } = string.Empty;

[Required(ErrorMessage = "La especie es obligatoria")]
public string Especie { get; set; } = string.Empty;


        [Required(ErrorMessage = "La edad es obligatoria")]
        [Range(0, 30, ErrorMessage = "Ingrese una edad válida")]
        public int Edad { get; set; }
    }
}
