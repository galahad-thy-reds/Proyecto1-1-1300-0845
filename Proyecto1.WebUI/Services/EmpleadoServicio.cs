using System.Collections.Generic;
using TeChineoTuLomito.WebApplication.Models;

namespace Proyecto1.WebUI.Services
{
    public class EmpleadoServicio : IEmpleadoServicio
    {
        private readonly List<Empleado> _empleados = new List<Empleado>();

        public EmpleadoServicio()
        {
            _empleados.Add(new Empleado
            {
                Cedula = "123456789",
                FechaNacimiento = new DateOnly(1990, 1, 1),
                FechaIngreso = new DateOnly(2020, 1, 1),
                SalarioDiario = 50.0,
                FechaRetiro = null,
                TipoEmpleado = "Veterinario"
            });
        }

        public void Actualizar(Empleado empleado)
        {
            var empleadoNuevo = Buscar(empleado.Cedula);
            if (empleadoNuevo != null)
            {
                empleadoNuevo.Cedula = empleado.Cedula;
                empleadoNuevo.FechaNacimiento = empleado.FechaNacimiento;
                empleadoNuevo.FechaIngreso = empleado.FechaIngreso;
                empleadoNuevo.SalarioDiario = empleado.SalarioDiario;
                empleadoNuevo.FechaRetiro = empleado.FechaRetiro;
                empleadoNuevo.TipoEmpleado = empleado.TipoEmpleado;
            }
        }

        public Empleado Buscar(string cedula)
        {
            Empleado empleado = _empleados.FirstOrDefault(e => e.Cedula.Equals(cedula));
            return empleado;
        }

        public void Eliminar(Empleado empleado)
        {
            _empleados.Remove(empleado);
        }

        public void Insertar(Empleado empleado)
        {
            _empleados.Add(empleado);
        }

        public IEnumerable<Empleado> Listar()
        {
            return _empleados;
        }
    }
}
