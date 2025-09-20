namespace Proyecto1.WebUI.Models
{
    public class Procedimiento
    {
        #region Propiedades
        /// <summary>
        /// Cedula del contacto que solicita el procedimiento
        /// </summary>
        public string? CedulaContacto { get; set; }
        /// <summary>
        /// Nombre de la mascota a la que se le realizara el procedimiento
        /// </summary>
        public string? NombreMascota { get; set; }
        /// <summary>
        /// Tipo de consulta a realizar
        /// </summary>
        public TipoConsulta? TipoConsulta { get; set; }
        /// <summary>
        /// Estado del procedimiento (en proceso, facturado, agendado)
        /// </summary>
        public string? Estado { get; set; }
        #endregion
    }
}
