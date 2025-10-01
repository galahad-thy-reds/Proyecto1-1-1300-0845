using Humanizer;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.WebUI.Models
{
    public class Procedimiento
    {
        #region Propiedades
        /// <summary>
        /// Identificador unico del procedimiento
        /// </summary>
        [DisplayName("Id del Procedimiento")]
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(0,8);
        /// <summary>
        /// Cedula del contacto que solicita el procedimiento
        /// </summary>
        [Required]
        [DisplayName("Cedula Contacto")]
        public string? CedulaContacto { get; set; }
        /// <summary>
        /// Nombre de la mascota a la que se le realizara el procedimiento
        /// </summary>
        [Required]
        [DisplayName("Nombre Mascota")]
        public string? NombreMascota { get; set; }
        /// <summary>
        /// Tipo de consulta a realizar
        /// </summary>
        [Required]
        [DisplayName("Tipo Consulta")]
        public TipoProcedimiento? TipoProcedimiento { get; set; }
        /// <summary>
        /// Estado del procedimiento (en proceso, facturado, agendado)
        /// </summary>
        [Required]
        public string? Estado { get; set; }
        #endregion
        #region Metodos
        /// <summary>
        /// Metodo para calcular el precio final del procedimiento con un impuesto del 15%
        /// </summary>
        /// <returns>PrecioFinal: Precio final del procedimiento con un impuesto del 15%</returns>
        public double PrecioFinal(double impuesto = 1.13)
        {
            if (TipoProcedimiento is not null)
            {
                return TipoProcedimiento.Precio * impuesto;
            }

            return 0;
        }
        #endregion
    }
}
