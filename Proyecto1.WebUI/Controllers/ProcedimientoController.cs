using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto1.WebUI.Services;

namespace Proyecto1.WebUI.Controllers
{
    public class ProcedimientoController : Controller
    {
        private readonly IProcedimientoServicio _procedimientoServicio;
        private readonly ITipoProcedimientoServicio _tipoProcedimientoServicio;

        public ProcedimientoController(IProcedimientoServicio procedimientoServicio, ITipoProcedimientoServicio tipoProcedimientoServicio)
        {
            _procedimientoServicio = procedimientoServicio;
            _tipoProcedimientoServicio = tipoProcedimientoServicio;
        }
        // GET: ProcedimientoController
        public ActionResult Index()
        {
            return View(_procedimientoServicio.Listar());
        }

        // GET: ProcedimientoController/Details/5
        public ActionResult Details(string id)
        {
            return View(_procedimientoServicio.Buscar(id));
        }

        // GET: ProcedimientoController/Create
        public ActionResult Create()
        {
            ViewBag.TiposDeProcedimientos = new SelectList(_tipoProcedimientoServicio.Listar(), "Nombre", "Nombre");
            return View();
        }

        // POST: ProcedimientoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var tipoProcedimiento = _tipoProcedimientoServicio.BuscarPorNombre(collection["TipoProcedimiento"]!);

                var procedimientoNuevo = new Models.Procedimiento
                {
                    CedulaContacto = collection["CedulaContacto"]!,
                    NombreMascota = collection["NombreMascota"]!,
                    TipoProcedimiento = tipoProcedimiento!,
                    Estado = collection["Estado"]!
                };

                _procedimientoServicio.Insertar(procedimientoNuevo);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProcedimientoController/Edit/5
        public ActionResult Edit(string id)
        {
            ViewBag.TiposDeProcedimientos = new SelectList(_tipoProcedimientoServicio.Listar(), "Nombre", "Nombre");
            return View(_procedimientoServicio.Buscar(id));
        }

        // POST: ProcedimientoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var tipoProcedimiento = _tipoProcedimientoServicio.BuscarPorNombre(collection["TipoProcedimiento"]!);
                var procedimientoActualizado = new Models.Procedimiento
                {
                    Id = collection["Id"]!,
                    CedulaContacto = collection["CedulaContacto"]!,
                    NombreMascota = collection["NombreMascota"]!,
                    TipoProcedimiento = tipoProcedimiento!,
                    Estado = collection["Estado"]!
                };

                _procedimientoServicio.Actualizar(procedimientoActualizado);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProcedimientoController/Delete/5
        public ActionResult Delete(string id)
        {
            var procedimiento = _procedimientoServicio.Buscar(id);
            _procedimientoServicio.Eliminar(procedimiento);
            return View(procedimiento);
        }

        // POST: ProcedimientoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
