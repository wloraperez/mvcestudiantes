using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcEstudiantes.Models;
using System.Data.Objects;

namespace mvcEstudiantes.Controllers
{
    public class SeleccionController : Controller
    {
        //
        // GET: /Seleccion/

        public ActionResult Index()
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            IEnumerable<EstudianteAsignatura> _estAsig = null;

            try
            {
                _estAsig = db.EstudianteAsignatura;

            }
            catch (Exception) { }

            return View(_estAsig);
        }

        //
        // GET: /Seleccion/Details/5

        public ActionResult Detail(int id)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            EstudianteAsignatura _estAsig = null;

            try
            {
                _estAsig = db.EstudianteAsignatura.Where(e => e.ID == id).FirstOrDefault();
            }
            catch (Exception) { }

            return View(_estAsig);
        }

        //
        // GET: /Seleccion/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Seleccion/Create

        [HttpPost]
        public ActionResult Create(EstudianteAsignatura _estAsig)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();

            try
            {
                db.AddToEstudianteAsignatura(_estAsig);
                db.SaveChanges();

                return RedirectToAction("Detail", new { id = _estAsig.ID });

            }
            catch (Exception e) { }

            return RedirectToAction("Index");
        }

        //
        // GET: /Seleccion/Edit/5

        public ActionResult Edit(int id)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            EstudianteAsignatura  _estAsig = null;

            try
            {
                _estAsig = db.EstudianteAsignatura.Where(e => e.ID == id).FirstOrDefault();
            }
            catch (Exception) { }

            return View(_estAsig);
        }

        //
        // POST: /Seleccion/Edit/5

        [HttpPost]
        public ActionResult Edit(EstudianteAsignatura estAsig)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            EstudianteAsignatura _estAsig = null;
            try
            {
                _estAsig = db.EstudianteAsignatura.Where(e => e.ID == estAsig.ID).FirstOrDefault();

                _estAsig.IDAsignatura = estAsig.IDAsignatura;
                _estAsig.IDEstudiante = estAsig.IDEstudiante;

                db.SaveChanges();

                return RedirectToAction("Detail", new { id = _estAsig.ID });
            }
            catch (Exception e) { }

            return RedirectToAction("Index");
        }

        //
        // GET: /Seleccion/Delete/5

        public ActionResult Delete(int id)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();

            EstudianteAsignatura _estAsig = null;

            try
            {
                _estAsig = db.EstudianteAsignatura.Where(e => e.ID == id).FirstOrDefault();

                db.EstudianteAsignatura.DeleteObject(_estAsig);

                db.SaveChanges();
            }
            catch (Exception e) { }

            return RedirectToAction("Index");
        }

        //
        // POST: /Seleccion/Delete/5

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
