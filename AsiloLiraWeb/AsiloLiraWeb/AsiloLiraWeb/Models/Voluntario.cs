using System.ComponentModel.DataAnnotations;

namespace AsiloLiraWeb.Models
{
    public class Voluntario
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El campo {0} es requerido")]
        [StringLength(50, MinimumLength = 3 ,ErrorMessage="El campo {0} debe tener entre {2} y {1} caracteres")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Edad { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string EntidadEducativa { get; set; }
        public string Carrera { get; set; }
        public string Semestre { get; set; }
        public string Ciudad { get; set; }
        public string Distrito { get; set; }

    }
}
