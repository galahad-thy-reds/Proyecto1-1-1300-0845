using Proyecto1.WebUI.Models;

namespace Proyecto1.WebUI.Services
{
    public class TipoProcedimientoServicio : ITipoProcedimientoServicio
    {
        private readonly List<TipoProcedimiento> _tiposProcedimientos = new List<TipoProcedimiento>();

        public TipoProcedimientoServicio()
        {
            // Datos de ejemplo
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Consulta de mascota", Nombre = "Consulta", Precio = 15000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Consulta de mascota después de las 18:00 hrs de lunes a sábado, o domingo o feriado", Nombre = "Consulta en horario especial", Precio = 17000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Mascota castrada con un peso de 0-5 kg", Nombre = "Castración de 0-5 kg", Precio = 35000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Mascota castrada con un peso de 5-10 kg", Nombre = "Castración de 5-10 kg", Precio = 45000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Mascota castrada con un peso de 10-20 kg", Nombre = "Castración de 10-20 kg", Precio = 55000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Mascota castrada con un peso de 20-30 kg", Nombre = "Castración de 20-30 kg", Precio = 85000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Mascota castrada con un peso de 30-50 kg", Nombre = "Castración de 30-50 kg", Precio = 100000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Costo por kilo de peso del paciente", Nombre = "Cirugía menor", Precio = 15000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Costo por kilo de peso del paciente", Nombre = "Cirugía mayor", Precio = 25000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Gromming completo de mascota pequeña", Nombre = "Gromming completo de mascota pequeña", Precio = 15000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Gromming completo de mascota mediana", Nombre = "Gromming completo de mascota mediana", Precio = 20000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Gromming completo de mascota grande", Nombre = "Gromming completo de mascota grande", Precio = 25000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Gromming completo de mascota extra grande", Nombre = "Gromming completo de mascota extra grande", Precio = 35000 });
            _tiposProcedimientos.Add(new TipoProcedimiento { Descripcion = "Vacunas Anuales de mascota", Nombre = "Vacunas anuales", Precio = 40000 });
        }
        public TipoProcedimiento? BuscarPorNombre(string nombre)
        {
            return _tiposProcedimientos.First(p => p.Nombre!.Contains(nombre));
        }

        public IEnumerable<TipoProcedimiento> Listar()
        {
            return _tiposProcedimientos;
        }
    }
}
