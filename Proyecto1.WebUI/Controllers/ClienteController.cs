using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto1.WebUI.Models;
using Proyecto1.WebUI.Services;

namespace Proyecto1.WebUI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteServicio _clienteServicio;
        // GET: ClienteController

        public ClienteController(IClienteServicio clienteServicio)
        {
            _clienteServicio = clienteServicio;
        }

        public ActionResult Index()
        {
            return View(_clienteServicio.Listar());
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(string cedula)
        {
            var cliente = _clienteServicio.Buscar(cedula);
            return View(cliente);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente clienteNuevo)
        {
            try
            {
                _clienteServicio.Insertar(clienteNuevo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(string cedula)
        {
            var cliente = _clienteServicio.Buscar(cedula);
            return View(cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cliente clienteModificado)
        {
            try
            {
                _clienteServicio.Actualizar(clienteModificado);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(string cedula)
        {
            var cliente = _clienteServicio.Buscar(cedula);
            return View(cliente);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string cedula, IFormCollection collection)
        {
            try
            {
                var cliente = _clienteServicio.Buscar(cedula);
                _clienteServicio.Eliminar(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
