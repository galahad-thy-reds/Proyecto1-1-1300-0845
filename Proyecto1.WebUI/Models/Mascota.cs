using System.ComponentModel;

namespace Proyecto1.WebUI.Models
{
    public class Mascota
    {
        #region Propiedades
        /// <summary>
        /// Cedula del dueño de la mascota
        /// </summary>
        [DisplayName("Cedula de Contacto")]
        public string? CedulaContacto { get; set; }
        /// <summary>
        /// Especie de la mascota (caballo, perro, gato, pez, cabra, conejo, vaca, cerdo, roedor, serpiente, otro.)
        /// </summary>
        public string? Especie { get; set; }
        /// <summary>
        /// Raza de la mascota (si es perro: pastor aleman, labrador, bulldog, etc. Si es gato: siamés, persa, etc.)
        /// </summary>
        public string? Raza { get; set; }
        /// <summary>
        /// Edad de la mascota en años (puede ser decimal, por ejemplo: 2.5)
        /// </summary>
        public double Edad { get; set; }
        /// <summary>
        /// Color de la mascota
        /// </summary>
        public string? Color { get; set; }
        /// <summary>
        /// Fecha de la ultima atencion de la mascota
        /// </summary>
        [DisplayName("Fecha de utlima atencion")]
        public DateOnly? UltimaAtencion { get; set; }
        /// <summary>
        /// Telefono de contacto del dueño de la mascota
        /// </summary>
        [DisplayName("Telefono de Contacto")]
        public string? TelefonoContacto { get; set; }
        /// <summary>
        /// Correo electronico del dueño de la mascota
        /// </summary>
        [DisplayName("Correo electronico de Contacto")]
        public string? CorreoContacto { get; set; }
        #endregion
    }
}
