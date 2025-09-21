using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto1.WebUI.Services;
using TeChineoTuLomito.WebApplication.Models;

namespace Proyecto1.WebUI.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly IEmpleadoServicio _empleadoServicio;

        public EmpleadoController(IEmpleadoServicio empleadoServicio)
        {
            _empleadoServicio = empleadoServicio;
        }
        // GET: EmpleadoController
        public ActionResult Index()
        {
            return View(_empleadoServicio.Listar());
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Details(string cedula)
        {
            var empleado = _empleadoServicio.Buscar(cedula);
            return View(empleado);
        }

        // GET: EmpleadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Empleado empleadoNuevo)
        {
            try
            {
                _empleadoServicio.Insertar(empleadoNuevo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Edit/5
        public ActionResult Edit(string cedula)
        {
            return View(_empleadoServicio.Buscar(cedula));
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Empleado empleado)
        {
            try
            {
                _empleadoServicio.Actualizar(empleado);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Delete/5
        public ActionResult Delete(string cedula)
        {
            var empleado = _empleadoServicio.Buscar(cedula);
            return View(empleado);
        }

        // POST: EmpleadoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string cedula, IFormCollection collection)
        {
            try
            {
                var empleado = _empleadoServicio.Buscar(cedula);
                _empleadoServicio.Eliminar(empleado);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
