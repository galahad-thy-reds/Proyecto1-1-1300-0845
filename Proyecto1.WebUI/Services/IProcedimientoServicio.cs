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
        public Procedimiento ObtenerProcedimiento(string criterioBusqueda);
        /// <summary>
        /// Metodo para eliminar un Procedimiento de la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Eliminar(Procedimiento procedimiento);
        /// <summary>
        /// Metodo para actualizar un Procedimiento existente en la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Actualizar(Procedimiento procedimiento);
        /// <summary>
        /// Metodo para listar todos los Procedimientos en la lista.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Procedimiento> Listar();
        /// <summary>
        /// Metodo para buscar Procedimientos por la cedula del contacto o el nombre de la mascota.
        /// </summary>
        /// <param name="criterioBusqueda"></param>
        /// <returns></returns>
        public IEnumerable<Procedimiento> Buscar(string criterioBusqueda);
    }
}
