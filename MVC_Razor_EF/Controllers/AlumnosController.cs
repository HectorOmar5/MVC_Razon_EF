using MVC_Razor_EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Razor_EF.Controllers
{
    public class AlumnosController : Controller
    {

        InstitutoTichEntities _BDContext = new InstitutoTichEntities();
        List<Alumnos> _listAlumnos;
        Alumnos _alumnos;

        // GET: Alumnos
        public ActionResult Index()
        {

            _listAlumnos = _BDContext.Alumnos.ToList();

            return View(_listAlumnos);
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            _alumnos = _BDContext.Alumnos.Find(id);
            return View(_alumnos);
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            //_alumnos = _BDContext.Alumnos.Find(id);

            return View();
            //return View();
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                //TODO: Add update logic here
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
