using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.WebUI.Models
{
    public class Mascota
    {
        #region Propiedades
        /// <summary>
        /// Cedula del dueño de la mascota
        /// </summary>
        [Required(ErrorMessage = "Por favor, digite la cedula del contacto")]
        [DisplayName("Cedula de Contacto")]
        public string? CedulaContacto { get; set; }
        /// <summary>
        /// Especie de la mascota (caballo, perro, gato, pez, cabra, conejo, vaca, cerdo, roedor, serpiente, otro.)
        /// </summary>
        [Required(ErrorMessage = "Por favor, seleccione una especie")]
        public string? Especie { get; set; }
        /// <summary>
        /// Raza de la mascota (si es perro: pastor aleman, labrador, bulldog, etc. Si es gato: siamés, persa, etc.)
        /// </summary>
        [Required(ErrorMessage = "Por favor, digite una raza")]
        public string? Raza { get; set; }
        /// <summary>
        /// Edad de la mascota en años (puede ser decimal, por ejemplo: 2.5)
        /// </summary>
        [Required(ErrorMessage = "Por favor, indique la edad de la mascota")]
        public double Edad { get; set; }
        /// <summary>
        /// Color de la mascota
        /// </summary>
        [Required(ErrorMessage = "Por favor, indique el color de la mascota")]
        public string? Color { get; set; }
        /// <summary>
        /// Fecha de la ultima atencion de la mascota
        /// </summary>
        [DisplayName("Fecha de utlima atencion")]
        public DateOnly? UltimaAtencion { get; set; }
        /// <summary>
        /// Telefono de contacto del dueño de la mascota
        /// </summary>
        [Required(ErrorMessage = "Por favor, indique el numero de telefono de contacto")]
        [DisplayName("Telefono de Contacto")]
        public string? TelefonoContacto { get; set; }
        /// <summary>
        /// Correo electronico del dueño de la mascota
        /// </summary>
        [Required(ErrorMessage = "Por favor, indique el correo electrico de contacto")]
        [DisplayName("Correo electronico de Contacto")]
        public string? CorreoContacto { get; set; }
        #endregion
    }
}
