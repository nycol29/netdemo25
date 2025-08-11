using System.ComponentModel.DataAnnotations;

namespace netdemo.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.1, 9999.99, ErrorMessage = "Ingrese un precio válido")]
        public decimal Precio { get; set; }

        public string Descripcion { get; set; }

    }
}
