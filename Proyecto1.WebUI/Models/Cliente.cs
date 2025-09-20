namespace Proyecto1.WebUI.Models
{
    public class Cliente
    {
        #region Propiedades
        /// <summary>
        /// Cedula del Cliente
        /// </summary>
        public string? Cedula { get; set; }
        /// <summary>
        /// Nombre completo del cliente
        /// </summary>
        public string? Nombre { get; set; }
        /// <summary>
        /// Provincia de residencia del cliente
        /// </summary>
        public string? Provincia { get; set; }
        /// <summary>
        /// Cantonc de residencia del cliente
        /// </summary>
        public string? Canton { get; set; }
        /// <summary>
        /// Distrito de residencia del cliente
        /// </summary>
        public string? Distrito { get; set; }
        /// <summary>
        /// Direccion exacta de residencia del cliente
        /// </summary>
        public string? Direccion { get; set; }
        /// <summary>
        /// Telefono de contacto del cliente
        /// </summary>
        public string? Telefono { get; set; }
        /// <summary>
        /// Metodo de contacto preferido del cliente (llamada, mensaje WhatsApp)
        /// </summary>
        public string? ContactoPreferido { get; set; }
        #endregion
    }
}
