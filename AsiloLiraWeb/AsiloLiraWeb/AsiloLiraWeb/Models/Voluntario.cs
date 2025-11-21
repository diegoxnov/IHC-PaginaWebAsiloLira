using System.ComponentModel.DataAnnotations;

namespace AsiloLiraWeb.Models
{
    public class Voluntario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(15, 120, ErrorMessage = "El campo {0} debe estar entre {1} y {2}")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(20, ErrorMessage = "El campo {0} no debe superar los {1} caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "El campo {0} debe tener exactamente 8 dígitos")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido")]
        [StringLength(100, ErrorMessage = "El campo {0} no debe superar los {1} caracteres")]
        public string Correo { get; set; }

        public string EntidadEducativa { get; set; }

        public string Carrera { get; set; }
    }
}
