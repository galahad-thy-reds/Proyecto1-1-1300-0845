using Proyecto1.WebUI.Models;

namespace Proyecto1.WebUI.Services
{
    public class MascotaServicio : IMascotaServicio
    {
        private readonly List<Mascota> _mascotas = new List<Mascota>();

        public MascotaServicio()
        {
            // Datos de ejemplo
            _mascotas.Add(new Mascota
            {
                CedulaContacto = "123456789",
                Especie = "Perro",
                Raza = "Labrador",
                Edad = 3.5,
                Color = "Marron",
                UltimaAtencion = DateOnly.FromDateTime(DateTime.Now.AddMonths(-2)),
                TelefonoContacto = "8888-8888",
                CorreoContacto = "someone@somwhere"
            });
        }
        /// <summary>
        /// Metodo para actualizar una mascota existente en la lista
        /// </summary>
        /// <param name="mascota"></param>
        public void Actualizar(Mascota mascota)
        {
            var mascotaActual = ObtenerMascota(mascota.CedulaContacto!);

            if (mascotaActual != null)
            {
                mascotaActual.CedulaContacto = mascota.CedulaContacto;
                mascotaActual.Especie = mascota.Especie;
                mascotaActual.Raza = mascota.Raza;
                mascotaActual.Edad = mascota.Edad;
                mascotaActual.Color = mascota.Color;
                mascotaActual.UltimaAtencion = mascota.UltimaAtencion;
                mascotaActual.TelefonoContacto = mascota.TelefonoContacto;
                mascotaActual.CorreoContacto = mascota.CorreoContacto;
            }
        }
        /// <summary>
        /// Metodo para buscar una mascota por el criterio de busqueda
        /// </summary>
        /// <param name="criterio"></param>
        /// <returns>Mascota encontrada</returns>
        public Mascota ObtenerMascota(string criterio)
        {
            Mascota mascota = _mascotas.FirstOrDefault(m => m.CedulaContacto == criterio)!;
            return mascota;

        }
        /// <summary>
        /// Metodo para eliminar una mascota de la lista
        /// </summary>
        /// <param name="mascota"></param>
        public void Eliminar(Mascota mascota)
        {
            _mascotas.Remove(mascota);
        }
        /// <summary>
        /// Metodo para insertar una Mascota en la lista
        /// </summary>
        /// <param name="mascota"></param>
        public void Insertar(Mascota mascota)
        {
            _mascotas.Add(mascota);
        }
        /// <summary>
        /// Metodo para listar todas las mascotas en la lista
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Mascota> Listar()
        {
            return _mascotas;
        }
        /// <summary>
        /// Metodo para buscar mascotas por un criterio de busqueda
        /// </summary>
        /// <param name="criterioBusqueda"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<Mascota> Buscar(string criterioBusqueda)
        {
            if (string.IsNullOrWhiteSpace(criterioBusqueda))
                return _mascotas;
            else
                return _mascotas.Where(m => m.CedulaContacto!.Contains(criterioBusqueda) ||
                                           m.Especie!.Contains(criterioBusqueda, StringComparison.OrdinalIgnoreCase) ||
                                           m.Raza!.Contains(criterioBusqueda, StringComparison.OrdinalIgnoreCase) ||
                                           m.Color!.Contains(criterioBusqueda, StringComparison.OrdinalIgnoreCase) ||
                                           m.CorreoContacto!.Contains(criterioBusqueda, StringComparison.OrdinalIgnoreCase) ||
                                           m.TelefonoContacto!.Contains(criterioBusqueda));
        }
    }
}
