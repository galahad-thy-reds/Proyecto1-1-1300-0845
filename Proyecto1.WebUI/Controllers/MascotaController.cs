using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto1.WebUI.Models;
using Proyecto1.WebUI.Services;

namespace Proyecto1.WebUI.Controllers
{
    public class MascotaController : Controller
    {
        private readonly IMascotaServicio _mascotaServicio;

        public MascotaController(IMascotaServicio mascotaServicio)
        {
            _mascotaServicio = mascotaServicio;
        }
        // GET: MascotaController
        public ActionResult Index()
        {
            return View(_mascotaServicio.Listar());
        }

        // GET: MascotaController/Details/5
        public ActionResult Details(string cedulaContacto)
        {
            var mascota = _mascotaServicio.Buscar(cedulaContacto);
            return View(mascota);
        }

        // GET: MascotaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MascotaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Mascota mascotaNueva)
        {
            try
            {
                _mascotaServicio.Insertar(mascotaNueva);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MascotaController/Edit/5
        public ActionResult Edit(string cedulaContacto)
        {
            var mascota = _mascotaServicio.Buscar(cedulaContacto);
            return View(mascota);
        }

        // POST: MascotaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Mascota mascotaModificada)
        {
            try
            {
                _mascotaServicio.Actualizar(mascotaModificada);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MascotaController/Delete/5
        public ActionResult Delete(string cedulaContacto)
        {
            var mascota = _mascotaServicio.Buscar(cedulaContacto);
            return View(mascota);
        }

        // POST: MascotaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string cedulaContacto, IFormCollection collection)
        {
            try
            {
                var mascota = _mascotaServicio.Buscar(cedulaContacto);
                _mascotaServicio.Eliminar(mascota);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
