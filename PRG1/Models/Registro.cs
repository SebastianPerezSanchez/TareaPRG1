
using System.ComponentModel.DataAnnotations;


namespace PRG1.Models
{
    public class Registro
    {
        [Required(ErrorMessage = "Por favor ingrese el nombre del producto")]
        public string Producto { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el precio del producto")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Por favor ingrese una descripción del producto")]
        public string Descripcion { get; set; }
    }
}
