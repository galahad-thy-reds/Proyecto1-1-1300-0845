using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeChineoTuLomito.WebApplication.Models
{
    public class Empleado
    {
        #region Propiedades
        /// <summary>
        /// Cedula del Empleado
        /// </summary>
        public string? Cedula { get; set; }
        /// <summary>
        /// Fecha de nacimiento del Empleado
        /// </summary>
        [DisplayName("Fecha Nacimiento")]
        public DateOnly FechaNacimiento { get; set; }
        /// <summary>
        /// Fecha de ingreso a la empresa del Empleado
        /// </summary>
        [DisplayName("Fecha de Ingreso")]
        public DateOnly FechaIngreso { get; set; }
        /// <summary>
        /// Salario por dia del Empleado
        /// </summary>
        [DisplayName("Salario por Dia")]
        public double SalarioDiario { get; set; }
        /// <summary>
        /// Fecha de retiro del Empleado, si no se ha retirado es null
        /// </summary>
        [DisplayName("Fecha de Retiro")]
        public DateOnly? FechaRetiro { get; set; }
        /// <summary>
        /// Tipo de contrato del Empleado, ejemplos: veterinario, asistente, administrativo, mantenimiento, groomer.
        /// </summary>
        [DisplayName("Tipo de Empleado")]
        public string? TipoEmpleado { get; set; }
        #endregion
    }
}
