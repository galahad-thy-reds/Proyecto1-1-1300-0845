using Proyecto1.WebUI.Models;

namespace Proyecto1.WebUI.Services
{
    public interface IMascotaServicio
    {
        /// <summary>
        /// Metodo para insertar una Mascota en la lista
        /// </summary>
        /// <param name="mascota"></param>
        public void Insertar(Mascota mascota);
        /// <summary>
        /// Metodo para buscar una mascota por la cedula de su contacto
        /// </summary>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public Mascota Buscar(string criterio);
        /// <summary>
        /// Metodos para eliminar una mascota de la lista
        /// </summary>
        /// <param name="mascota"></param>
        public void Eliminar(Mascota mascota);
        /// <summary>
        /// Metodo para actualizar una mascota existente en la lista
        /// </summary>
        /// <param name="mascota"></param>
        public void Actualizar(Mascota mascota);
        /// <summary>
        /// Metodo para listar todas las mascotas en la lista
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Mascota> Listar();
    }
}
