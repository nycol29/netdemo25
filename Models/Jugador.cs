using System.ComponentModel.DataAnnotations;

namespace netdemo.Models
{
    public class Jugador
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        [Range(10, 100)]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Selecciona la frecuencia")]
        public string FrecuenciaJuego { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(0, 20)]
        public int AniosJugando { get; set; }
    }
}
