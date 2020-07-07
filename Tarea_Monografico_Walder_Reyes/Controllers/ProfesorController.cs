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
    [BreadCrumb(Title = "Profesor", Url ="/Profesor/Index/", Order = 0)]

    public class ProfesorController : Controller
    {
        [BreadCrumb(Title = "Lista Profesor",  Order = 1)]

        // GET: Profesor
        public static List<Profesor> profesor { get; set; }
        public ActionResult Index(string filter, int page = 1,
                                            string sortExpression = "Nombre")
        {
            if (profesor == null)
                profesor = new List<Profesor>()
                {
                    new Profesor()
                };
            List<Profesor> filtrada = profesor;
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filtrada = profesor.FindAll(x => x.Nombre.ToUpper().Contains(filter.ToUpper()));
            }


            var model = PagingList.Create(filtrada, 5, page, sortExpression, "Nombre");
            model.RouteValue = new RouteValueDictionary {
                            { "filter", filter}
            };
            model.Action = "Index";

            return View(model);
        }
        [BreadCrumb(Title = "Detalle Profesor", Order = 2)]


        // GET: Profesor/Details/5
        public ActionResult Details(int id)
        {
            var modelo = profesor.Find(x => x.Id == id);
            if (modelo == null)
            {
                return RedirectToAction(nameof(Index));

            }
            return View(modelo);
        }
        [BreadCrumb(Title = "Crear Profesor", Order = 2)]


        // GET: Profesor/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Profesor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Profesor modelo)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    profesor.Add(modelo);
                    return RedirectToAction(nameof(Index));


                }
            }
            catch
            {
                return View(modelo);
            }
            return View(modelo);

        }
        [BreadCrumb(Title = "Editar Profesor", Order = 3)]


        // GET: Profesor/Edit/5
        public ActionResult Edit(int id)
        {
            var modelo = profesor.Find(x => x.Id == id);
            if (modelo == null)
                return RedirectToAction(nameof(Index));



            return View(modelo);
        }
        // POST: Profesor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Profesor modelo)
        {
            try
            {
                if (modelo != null)
                {
                    int indice = profesor.FindIndex(x => x.Id == modelo.Id);
                    profesor.RemoveAt(indice);
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
        [BreadCrumb(Title = "Eliminar Profesor", Order = 4)]


        // GET: Profesor/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = profesor.Find(x => x.Id == id);
            if (modelo == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(modelo);
        }

        // POST: Profesor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Profesor modelo)
        {
            try
            {

                if (modelo != null)
                {
                    int indice = profesor.FindIndex(x => x.Id == modelo.Id);
                    profesor.RemoveAt(indice);
                    return RedirectToAction(nameof(Index));

                }
                // TODO: Add delete logic here

            }
            catch
            {
                return View(modelo);
            }
            return View(modelo);

        }
    }
}