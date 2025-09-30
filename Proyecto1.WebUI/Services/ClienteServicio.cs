using Proyecto1.WebUI.Models;
using TeChineoTuLomito.WebApplication.Models;

namespace Proyecto1.WebUI.Services
{
    public class ClienteServicio : IClienteServicio
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();

        public ClienteServicio() { 
            // Datos de ejemplo
            _clientes.Add(new Cliente
            {
                Cedula = "123456789",
                Nombre = "Juan Perez",
                Provincia = "San Jose",
                Canton = "Central",
                Distrito = "Carmen",
                Direccion = "Calle 1, Casa 2",
                Telefono = "8888-8888",
                ContactoPreferido = "WhatsApp"
            });
            _clientes.Add(new Cliente
            {
                Cedula = "987654321",
                Nombre = "Maria Gomez",
                Provincia = "Alajuela",
                Canton = "Central",
                Distrito = "Alajuela",
                Direccion = "Avenida 3, Casa 4",
                Telefono = "7777-7777",
                ContactoPreferido = "Llamada"
            });
        }

        /// <summary>
        /// Metodo para actualizar un cliente existente en la lista.
        /// </summary>
        /// <param name="cliente"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Actualizar(Cliente cliente)
        {
            var clienteActual = ObtenerCliente(cliente.Cedula!);

            if(clienteActual != null)
            {
                clienteActual.Cedula = cliente.Cedula;
                clienteActual.Nombre = cliente.Nombre;
                clienteActual.Provincia = cliente.Provincia;
                clienteActual.Canton = cliente.Canton;
                clienteActual.Distrito = cliente.Distrito;
                clienteActual.Direccion = cliente.Direccion;
                clienteActual.Telefono = cliente.Telefono;
                clienteActual.ContactoPreferido = cliente.ContactoPreferido;
            }

        }
        /// <summary>
        /// Metodo para buscar un cliente por su cedula.
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Cliente ObtenerCliente(string cedula)
        {
            Cliente cliente = _clientes.FirstOrDefault(c => c.Cedula!.Equals(cedula))!;
            return cliente;
        }
        /// <summary>
        /// Metodo para eliminar un cliente de la lista.
        /// </summary>
        /// <param name="cliente"></param>
        public void Eliminar(Cliente cliente)
        {
            _clientes.Remove(cliente);
        }
        /// <summary>
        /// Metodod para insertar un nuevo cliente en la lista.
        /// </summary>
        /// <param name="cliente"></param>
        public void Insertar(Cliente cliente)
        {
            _clientes.Add(cliente);
        }
        /// <summary>
        /// Metodo para listar todos los clientes en la lista.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Cliente> Listar()
        {
            return _clientes;
        }
        /// <summary>
        /// Metodo para buscar clientes por nombre o cedula de acuerdo a un criterio de busqueda.
        /// </summary>
        /// <param name="criterioBusqueda"></param>
        /// <returns></returns>
        public IEnumerable<Cliente> Buscar(string criterioBusqueda)
        {
            if (string.IsNullOrWhiteSpace(criterioBusqueda))
                return _clientes;
            else
                return _clientes.Where(c => c.Cedula!.Contains(criterioBusqueda) || c.Nombre!.Contains(criterioBusqueda));
        }
    }
}
