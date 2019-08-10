using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcEstudiantes.Models;
using System.Data.Objects;

namespace mvcEstudiantes.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Bienvenido al manejador de estudiantes y asignaturas.";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Estudiante _est)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();

            try
            {
                db.AddToEstudiante(_est);
                db.SaveChanges();

                return RedirectToAction("Detail", new { id = _est.ID });

            }
            catch (Exception e) { }

            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            Estudiante _est = null;

            try
            {
                _est = db.Estudiante.Where(e => e.ID == id).FirstOrDefault();
            }
            catch (Exception) { }

            return View(_est);
        }

        [HttpPost]
        public ActionResult Edit(Estudiante _est)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            Estudiante _estudiante = null;
            try
            {
                _estudiante = db.Estudiante.Where(e => e.ID == _est.ID ).FirstOrDefault();

                _estudiante.Nombre = _est.Nombre;
                _estudiante.Apellido = _est.Apellido;
                _estudiante.Cedula = _est.Cedula;
                _estudiante.Email = _est.Email;
                _estudiante.FechaNacimiento = _est.FechaNacimiento;
                _estudiante.Telefono = _est.Telefono;

                db.SaveChanges();

                return RedirectToAction("Detail", new { id = _estudiante.ID });
            }
            catch (Exception e) { }

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            IEnumerable<Estudiante> _est = null;

            try
            {
                _est = db.Estudiante;
            }
            catch (Exception) { }

            return View(_est);
        }

        public ActionResult Detail(int id)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();
            Estudiante _est = null;

            try
            {
                _est = db.Estudiante.Where(e => e.ID == id).FirstOrDefault();
            }
            catch (Exception) { }

            return View(_est);
        }
        
        public ActionResult Delete(int id)
        {
            mvcEstudiantesEntities db = new mvcEstudiantesEntities();

            Estudiante _est = null;
            IEnumerable<EstudianteAsignatura> _estAsig = null;

            EstudianteAsignatura _tempEA = null;

            try
            {
                _est = db.Estudiante.Where(e => e.ID == id).FirstOrDefault();
                _estAsig = db.EstudianteAsignatura.Where(k => k.IDEstudiante == id);

                foreach (var item in _estAsig)
                {
                    _tempEA = db.EstudianteAsignatura.Where(l => l.IDAsignatura == item.IDAsignatura && l.IDEstudiante == item.IDEstudiante).FirstOrDefault();
                    db.EstudianteAsignatura.DeleteObject(_tempEA);
                }

                db.Estudiante.DeleteObject(_est);

                db.SaveChanges();
            }
            catch (Exception e) { }

            return RedirectToAction ("List");
        }
    }
}
