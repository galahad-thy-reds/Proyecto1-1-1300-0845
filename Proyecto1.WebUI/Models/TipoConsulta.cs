namespace Proyecto1.WebUI.Models
{
    public class TipoConsulta
    {
        #region Propiedades
        /// <summary>
        /// Nombre del tipo de consulta (consulta general, vacunacion, desparasitacion, cirugia, emergencia, otro)
        /// </summary>
        public string? Nombre { get; set; }
        /// <summary>
        /// Descripcion del tipo de consulta
        /// </summary>
        public string? Descripcion { get; set; }
        /// <summary>
        /// Precio del tipo de consulta
        /// </summary>
        public double Precio { get; set; }
        #endregion
    }
}
