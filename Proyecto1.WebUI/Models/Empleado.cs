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
        [Required(ErrorMessage = "Por favor, digite la cedula del empleado")]
        public string? Cedula { get; set; }
        /// <summary>
        /// Fecha de nacimiento del Empleado
        /// </summary>
        [Required(ErrorMessage = "Por favor, digite la fecha de nacimiento")]
        [DisplayName("Fecha Nacimiento")]
        public DateOnly FechaNacimiento { get; set; }
        /// <summary>
        /// Fecha de ingreso a la empresa del Empleado
        /// </summary>
        [Required(ErrorMessage = "Por favor, digite la fecha de ingreso")]
        [DisplayName("Fecha de Ingreso")]
        public DateOnly FechaIngreso { get; set; }
        /// <summary>
        /// Salario por dia del Empleado
        /// </summary>
        [Required(ErrorMessage = "Por favor, el salario por dia")]
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
        [Required(ErrorMessage = "Por favor, seleccione un tipo de empleado")]
        [DisplayName("Tipo de Empleado")]
        public string? TipoEmpleado { get; set; }
        #endregion
    }
}
