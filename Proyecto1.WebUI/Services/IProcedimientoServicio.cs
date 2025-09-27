using Proyecto1.WebUI.Models;

namespace Proyecto1.WebUI.Services
{
    public interface IProcedimientoServicio
    {
        /// <summary>
        /// Metodo para insetar un Procedimiento en la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Insertar(Procedimiento procedimiento);
        /// <summary>
        /// Metodo para buscar un Procedimiento por la cedula del contacto.
        /// </summary>
        /// <param name="cedulaContacto"></param>
        /// <returns></returns>
        public Procedimiento Buscar(string criterioBusqueda);
        /// <summary>
        /// Metodo para eliminar un Procedimiento de la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Eliminar(Procedimiento procedimiento);
        /// <summary>
        /// Procedimiento para actualizar un Procedimiento existente en la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Actualizar(Procedimiento procedimiento);
        /// <summary>
        /// Procedimiento para listar todos los Procedimientos en la lista.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Procedimiento> Listar();
    }
}
