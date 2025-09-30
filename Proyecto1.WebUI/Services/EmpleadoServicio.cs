using System.Collections.Generic;
using TeChineoTuLomito.WebApplication.Models;

namespace Proyecto1.WebUI.Services
{
    public class EmpleadoServicio : IEmpleadoServicio
    {
        private readonly List<Empleado> _empleados = new List<Empleado>();
        /// <summary>
        /// Constructor que inicializa la lista de empleados con un empleado de ejemplo.
        /// </summary>
        public EmpleadoServicio()
        {
            _empleados.Add(new Empleado
            {
                Cedula = "123456789",
                FechaNacimiento = new DateOnly(1990, 1, 1),
                FechaIngreso = new DateOnly(2020, 1, 1),
                SalarioDiario = 50.0,
                FechaRetiro = null,
                TipoEmpleado = "Veterinario"
            });
        }
        /// <summary>
        /// Metodo para actualizar un Empleado existente en la lista.
        /// </summary>
        /// <param name="empleado"></param>
        public void Actualizar(Empleado empleado)
        {
            var empleadoActual = ObtenerEmpleado(empleado.Cedula);
            if (empleadoActual != null)
            {
                empleadoActual.Cedula = empleado.Cedula;
                empleadoActual.FechaNacimiento = empleado.FechaNacimiento;
                empleadoActual.FechaIngreso = empleado.FechaIngreso;
                empleadoActual.SalarioDiario = empleado.SalarioDiario;
                empleadoActual.FechaRetiro = empleado.FechaRetiro;
                empleadoActual.TipoEmpleado = empleado.TipoEmpleado;
            }
        }
        /// <summary>
        /// Metodo para buscar un Empleado por su cedula.
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public Empleado ObtenerEmpleado(string cedula)
        {
            Empleado empleado = _empleados.FirstOrDefault(e => e.Cedula!.Equals(cedula))!;
            return empleado;
        }
        /// <summary>
        /// Metodo para eliminar un Empleado de la lista.
        /// </summary>
        /// <param name="empleado"></param>
        public void Eliminar(Empleado empleado)
        {
            _empleados.Remove(empleado);
        }
        /// <summary>
        /// Metodo para insertar un nuevo Empleado en la lista.
        /// </summary>
        /// <param name="empleado"></param>
        public void Insertar(Empleado empleado)
        {
            _empleados.Add(empleado);
        }
        /// <summary>
        /// Metodo para listar todos los Empleados en la lista.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Empleado> Listar()
        {
            return _empleados;
        }
        /// <summary>
        /// Metodo para buscar clientes por cedula o tipo de empleado, de acuerdo a un criterio de busqueda.
        /// </summary>
        /// <param name="criterioBusqueda"></param>
        /// <returns></returns>
        public IEnumerable<Empleado> Buscar(string criterioBusqueda)
        {
            if(string.IsNullOrWhiteSpace(criterioBusqueda))
                return _empleados;
            else
                return _empleados.Where(e => e.Cedula!.Contains(criterioBusqueda) || e.TipoEmpleado!.Contains(criterioBusqueda));
        }
    }
}
