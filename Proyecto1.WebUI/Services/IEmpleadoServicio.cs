using System.Collections;
using TeChineoTuLomito.WebApplication.Models;

namespace Proyecto1.WebUI.Services
{
    public interface IEmpleadoServicio
    {
        public void Insertar(Empleado empleado);
        public Empleado Buscar(string cedula);
        public void Eliminar(Empleado empleado);
        public void Actualizar(Empleado empleado);
        public IEnumerable<Empleado> Listar();
    }
}
