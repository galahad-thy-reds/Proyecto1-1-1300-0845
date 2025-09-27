using Proyecto1.WebUI.Models;

namespace Proyecto1.WebUI.Services
{
    public class ProcedimientoServicio : IProcedimientoServicio
    {
        private readonly List<Procedimiento> _procedimientos = new List<Procedimiento>();

        public ProcedimientoServicio()
        {
            // Datos de ejemplo
            _procedimientos.Add(new Procedimiento
            {
                CedulaContacto = "123456789",
                NombreMascota = "Firulais",
                TipoConsulta = new TipoConsulta { Descripcion="Consulta de mascota", Nombre ="Consulta", Precio = 15000},
                Estado = "En proceso"
            });
            _procedimientos.Add(new Procedimiento
            {
                CedulaContacto = "987654321",
                NombreMascota = "Michi",
                TipoConsulta = new TipoConsulta { Descripcion = "Costo por kilo de peso del paciente", Nombre = "Cirugia Mayor", Precio = 25000},
                Estado = "Agendado"
            });
        }
        /// <summary>
        /// Metodo para actualizar un Procedimiento existente en la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Actualizar(Procedimiento procedimiento)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo para buscar un Procedimiento por la cedula del contacto.
        /// </summary>
        /// <param name="cedulaContacto"></param>
        /// <returns>Procedimiento </returns>
        public Procedimiento Buscar(string criterioBusqueda)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo para eliminar un Procedimiento de la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Eliminar(Procedimiento procedimiento)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo para insetar un Procedimiento en la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Insertar(Procedimiento procedimiento)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo para listar todos los Procedimientos en la lista.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Procedimiento> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
