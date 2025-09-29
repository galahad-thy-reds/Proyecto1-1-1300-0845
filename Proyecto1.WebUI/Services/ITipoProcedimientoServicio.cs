using Proyecto1.WebUI.Models;

namespace Proyecto1.WebUI.Services
{
    public interface ITipoProcedimientoServicio
    {
        /// <summary>
        /// Procedimieno para buscar un tipo de procedimiento por su nombre.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public TipoProcedimiento? BuscarPorNombre(string nombre);
        /// <summary>
        /// Procedimiento para listar todos los tipos de procedimientos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TipoProcedimiento> Listar();
    }
}
