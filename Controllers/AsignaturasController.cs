using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcEstudiantes.Models;
using System.Data.Objects;

namespace mvcEstudiantes.Controllers
{
    public class AsignaturasController : Controller
    {
        //
        // GET: /Asignaturas/

        public ActionResult Index()
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            IEnumerable<Asignaturas> _asig = null;

            try
            {
                _asig = db.Asignaturas;
            }
            catch (Exception) { }

            return View(_asig);
        }

        //
        // GET: /Asignaturas/Details/5

        public ActionResult Detail(int id)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            Asignaturas _asig = null;

            try
            {
                _asig = db.Asignaturas.Where(e => e.ID == id).FirstOrDefault();
            }
            catch (Exception) { }

            return View(_asig);
        }

        //
        // GET: /Asignaturas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Asignaturas/Create

        [HttpPost]
        public ActionResult Create(Asignaturas _asig)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();

            try
            {
                db.AddToAsignaturas(_asig);
                db.SaveChanges();

                return RedirectToAction("Detail", new { id = _asig.ID });

            }
            catch (Exception e) { }

            return RedirectToAction("Index");
        }

        //
        // GET: /Asignaturas/Edit/5

        public ActionResult Edit(int id)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            Asignaturas _asig = null;

            try
            {
                _asig = db.Asignaturas.Where(e => e.ID == id).FirstOrDefault();
            }
            catch (Exception) { }

            return View(_asig);
        }

        //
        // POST: /Asignaturas/Edit/5

        [HttpPost]
        public ActionResult Edit(Asignaturas _asig)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            Asignaturas _asignatura = null;
            try
            {
                _asignatura = db.Asignaturas.Where(e => e.ID == _asig.ID).FirstOrDefault();

                _asignatura.Nombre = _asig.Nombre;
                _asignatura.Horario = _asig.Horario;

                db.SaveChanges();

                return RedirectToAction("Detail", new { id = _asignatura.ID });
            }
            catch (Exception e) { }

            return RedirectToAction("Index");
        }

        //
        // GET: /Asignaturas/Delete/5

        public ActionResult Delete(int id)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();

            Asignaturas _asig = null;

            try
            {
                _asig = db.Asignaturas.Where(e => e.ID == id).FirstOrDefault();

                db.Asignaturas.DeleteObject(_asig);

                db.SaveChanges();
            }
            catch (Exception e) { }

            return RedirectToAction("Index");
        }

        //
        // POST: /Asignaturas/Delete/5

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
