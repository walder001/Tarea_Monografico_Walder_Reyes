﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarea_Monografico_Walder_Reyes.Models;
using DNTBreadCrumb.Core;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;
using System.Text;
using Microsoft.Extensions.Options;

namespace Tarea_Monografico_Walder_Reyes.Controllers
{
    [BreadCrumb(Title ="Empleado", Url="/Empleado/Index", Order = 0)]
    public class EmpleadoController : Controller
    {
     

        // GET: Empleado
        public static List<Empleado> empleado;
        [BreadCrumb(Title = "Titulo Empleado", Order = 1)]
        public ActionResult Index(string filter, int page = 1,
                                            string sortExpression = "Nombre")
        {
            
            if (empleado == null)
                empleado = new List<Empleado>
                {
                  new Empleado() { }
                };

            List<Empleado> filtrada = empleado;
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filtrada = empleado.FindAll(x => x.Nombre.ToUpper().Contains(filter.ToUpper()));
            }


            var model = PagingList.Create(filtrada, 5, page, sortExpression, "Nombre");
            model.RouteValue = new RouteValueDictionary {
                            { "filter", filter}
            };
            model.Action = "Index";

            return View(model);
        }
        [BreadCrumb(Title = "Detalle Empleado", Order = 2)]

        // GET: Empleado/Details/5
        public ActionResult Details(int id)
        {
            var modelo = empleado.Find(x => x.Id == id);
            if (modelo == null)
            {
                return RedirectToAction(nameof(Index));

            }

            return View(modelo);
        }
        [BreadCrumb(Title = "Crear Empleado", Order = 2)]

        // GET: Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleado/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Empleado modelo)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    empleado.Add(modelo);
                    return RedirectToAction(nameof(Index));
                }
         
            }
            catch
            {
                return View(modelo);
            }
            return View(modelo);
        }
        [BreadCrumb(Title = "Editar Empleado", Order = 3)]

        // GET: Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            var modelo = empleado.Find( x=> x.Id == id);
            if (modelo == null)
                return RedirectToAction(nameof(Index));
            

          
            return View(modelo);
        }

        // POST: Empleado/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Empleado modelo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int indice = empleado.FindIndex(x => x.Id == modelo.Id);
                    empleado[indice] = modelo;
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
        [BreadCrumb(Title = "Eliminar Empleado", Order = 4)]

        // GET: Empleado/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = empleado.Find(x => x.Id == id);

            if (modelo == null)
                return RedirectToAction(nameof(Index));

            return View(modelo);
        }

        // POST: Empleado/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Empleado modelo)
        {
            try
            {
                if (modelo != null)
                {
                    int indice = empleado.FindIndex(x => x.Id == modelo.Id);
                    empleado.RemoveAt(indice);
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

        public ActionResult Amdin()
        {
            return View();
        }
    }
}