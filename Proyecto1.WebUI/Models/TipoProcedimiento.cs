using System.ComponentModel;

namespace Proyecto1.WebUI.Models
{
    public class TipoProcedimiento
    {
        #region Propiedades
        /// <summary>
        /// Nombre del tipo de consulta (consulta general, vacunacion, desparasitacion, cirugia, emergencia, otro)
        /// </summary>
        [DisplayName("Tipo Procedimiento")]
        public string? Nombre { get; set; }
        /// <summary>
        /// Descripcion del tipo de consulta
        /// </summary>
        [DisplayName("Descripcion del Procedimiento")]
        public string? Descripcion { get; set; }
        /// <summary>
        /// Precio del tipo de consulta
        /// </summary>
        [DisplayName("Precio del procedimiento (sin IVA)")]
        public double Precio { get; set; }
        #endregion
    }
}
