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
                TipoProcedimiento = new TipoProcedimiento { Descripcion = "Consulta de mascota", Nombre = "Consulta", Precio = 15000 },
                Estado = "En proceso"
            });
            _procedimientos.Add(new Procedimiento
            {
                CedulaContacto = "987654321",
                NombreMascota = "Michi",
                TipoProcedimiento = new TipoProcedimiento { Descripcion = "Costo por kilo de peso del paciente", Nombre = "Cirugía menor", Precio = 15000 },
                Estado = "Agendado"
            });
        }
        /// <summary>
        /// Metodo para actualizar un Procedimiento existente en la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Actualizar(Procedimiento procedimiento)
        {
            var procedimientoActual = ObtenerProcedimiento(procedimiento.Id!);

            if (procedimientoActual != null)
            {
                procedimientoActual.CedulaContacto = procedimiento.CedulaContacto;
                procedimientoActual.NombreMascota = procedimiento.NombreMascota;
                procedimientoActual.TipoProcedimiento = procedimiento.TipoProcedimiento;
                procedimientoActual.Estado = procedimiento.Estado;
            }
        }
        /// <summary>
        /// Metodo para buscar un Procedimiento por la cedula del contacto.
        /// </summary>
        /// <param name="cedulaContacto"></param>
        /// <returns>Procedimiento </returns>
        public Procedimiento ObtenerProcedimiento(string criterioBusqueda)
        {
            var procedimiento = _procedimientos.FirstOrDefault(p => p.Id.Contains(criterioBusqueda))!;
            return procedimiento;
        }
        /// <summary>
        /// Metodo para eliminar un Procedimiento de la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Eliminar(Procedimiento procedimiento)
        {
            _procedimientos.Remove(procedimiento);
        }
        /// <summary>
        /// Metodo para insetar un Procedimiento en la lista.
        /// </summary>
        /// <param name="procedimiento"></param>
        public void Insertar(Procedimiento procedimiento)
        {
            _procedimientos.Add(procedimiento);
        }
        /// <summary>
        /// Metodo para listar todos los Procedimientos en la lista.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Procedimiento> Listar()
        {
            return _procedimientos;
        }

        public IEnumerable<Procedimiento> Buscar(string criterioBusqueda)
        {
            if (string.IsNullOrWhiteSpace(criterioBusqueda))
                return _procedimientos;
            else
                return _procedimientos.Where(p => p.CedulaContacto!.Contains(criterioBusqueda, StringComparison.OrdinalIgnoreCase) ||
                                                  p.NombreMascota!.Contains(criterioBusqueda, StringComparison.OrdinalIgnoreCase));
        }
    }
}
