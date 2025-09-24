using Proyecto1.WebUI.Models;
using TeChineoTuLomito.WebApplication.Models;

namespace Proyecto1.WebUI.Services
{
    public interface IClienteServicio
    {
        /// <summary>
        /// Metodo para insertar un Cliente en la lista
        /// </summary>
        /// <param name="cliente"></param>
        public void Insertar(Cliente cliente);
        /// <summary>
        /// Metodo para buscar un cliente por su cedula
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public Cliente Buscar(string cedula);
        /// <summary>
        /// Metodo para eliminar un cliente de la lista
        /// </summary>
        /// <param name="cliente"></param>
        public void Eliminar(Cliente cliente);
        /// <summary>
        /// Metodo para actualizar un cliente existente en la lista
        /// </summary>
        /// <param name="cliente"></param>
        public void Actualizar(Cliente cliente);
        /// <summary>
        /// Metodo para listar todos los clientes en la lista
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Cliente> Listar();
    }
}
