using System.Collections;
using TeChineoTuLomito.WebApplication.Models;

namespace Proyecto1.WebUI.Services
{
    public interface IEmpleadoServicio
    {
        /// <summary>
        /// Metodo para insertar un Empleado en la lista.
        /// </summary>
        /// <param name="empleado"></param>
        public void Insertar(Empleado empleado);
        /// <summary>
        /// Metodod para buscar un Empleado por su cedula.
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public Empleado Buscar(string cedula);
        /// <summary>
        /// Metodo para eliminar un Empleado de la lista.
        /// </summary>
        /// <param name="empleado"></param>
        public void Eliminar(Empleado empleado);
        /// <summary>
        /// Metodo para actualizar un Empleado existente en la lista.
        /// </summary>
        /// <param name="empleado"></param>
        public void Actualizar(Empleado empleado);
        /// <summary>
        /// Metodo para listar todos los Empleados en la lista.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Empleado> Listar();
    }
}
