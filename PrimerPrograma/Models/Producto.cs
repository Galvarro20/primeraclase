using System.ComponentModel.DataAnnotations;

namespace PrimerPrograma.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre Es Obligatorio")]
        [Display(Name = "Nombre Del Producto")]
        public string NombreProducto { get; set; }

        [Required(ErrorMessage = "La Descripcion Es Obligatoria")]
        public decimal Precio { get; set; }
    }
}
