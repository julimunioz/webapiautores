using System.ComponentModel.DataAnnotations;

namespace WebApiAutores.DTOs
{
    public class AutorCreacionDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Fecha_nacimiento { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
    }
}
