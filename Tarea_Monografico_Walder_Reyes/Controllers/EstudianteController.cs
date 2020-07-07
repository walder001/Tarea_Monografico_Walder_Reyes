using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarea_Monografico_Walder_Reyes.Models;
using DNTBreadCrumb.Core;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;

namespace Tarea_Monografico_Walder_Reyes.Controllers
{
    [BreadCrumb(Title ="Estudiante", Url ="/Estudiente/Index/", Order =0)]
    public class EstudianteController : Controller
    {
        [BreadCrumb(Title = "Lista Estudiante", Order = 1)]

        // GET: Estudiante
        public static List<Estudiante> estudiantes { get; set; }
        public ActionResult Index(string filter, int page = 1,
                                            string sortExpression = "Nombre")
        {
            if (estudiantes == null)
                estudiantes = new List<Estudiante>()
                {
                    new Estudiante()

                };
            List<Estudiante> filtrada = estudiantes;
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filtrada = estudiantes.FindAll(x => x.Nombre.ToUpper().Contains(filter.ToUpper()));
            }


            var model = PagingList.Create(filtrada, 5, page, sortExpression, "Nombre");
            model.RouteValue = new RouteValueDictionary {
                            { "filter", filter}
            };
            model.Action = "Index";

            return View(model);

        }
        [BreadCrumb(Title = "Detalle Estudiante", Order = 1)]

        // GET: Estudiante/Details/5
        public ActionResult Details(int id)
        {
            var modelo = estudiantes.Find(x => x.Id == id);
            if (modelo == null)
            {
                RedirectToAction(nameof(Index));
            }
            return View(modelo);
        }
        [BreadCrumb(Title = "Crear Estudiante", Order = 2)]

        // GET: Estudiante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiante/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Estudiante modelo)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    estudiantes.Add(modelo);

                    return RedirectToAction(nameof(Index));
                }

            }
            catch
            {
                return View(modelo);
            }

            return View(modelo);

        }
        [BreadCrumb(Title = "Editar Estudiante", Order = 3)]

        // GET: Estudiante/Edit/5
        public ActionResult Edit(int id)
        {
            var modelo = estudiantes.Find(x => x.Id == id);
            if (modelo == null)
                return RedirectToAction(nameof(Index));



            return View(modelo);
        }

        // POST: Estudiante/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Estudiante modelo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int indice = estudiantes.FindIndex(x => x.Id == modelo.Id);
                    estudiantes[indice] = modelo;
                    return RedirectToAction(nameof(Index));

                }
                // TODO: Add update logic here

            }
            catch
            {
                return View(modelo);

            }
            return View(modelo);

        }
        [BreadCrumb(Title = "Eliminar Estudiante", Order = 4)]

        // GET: Estudiante/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = estudiantes.Find(x => x.Id == id);
            if (modelo == null)
                return RedirectToAction(nameof(Index));
            return View(modelo);
        }

        // POST: Estudiante/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Estudiante modelo)
        {
            try
            {
                if (modelo != null)
                {
                    int indice = estudiantes.FindIndex(x => x.Id == modelo.Id);
                    estudiantes.RemoveAt(indice);
                    return RedirectToAction(nameof(Index));


                }
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(modelo);
            }
        }
    }
}