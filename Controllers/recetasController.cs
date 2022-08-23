using MVC.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class recetasController : Controller
    {
        private restauranteEntities1 db = new restauranteEntities1();

        // GET: recetas
        public ActionResult Index()
        {
            return View(db.receta.ToList());
        }

        // GET: recetas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            receta receta = db.receta.Find(id);
            if (receta == null)
            {
                return HttpNotFound();
            }
            return View(receta);
        }

        // GET: recetas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: recetas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idreceta,nombre_receta,descripcion,valorReceta,ingrdientes,ubicacionReceta")] receta receta)
        {
            if (ModelState.IsValid)
            {
                db.receta.Add(receta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(receta);
        }

        // GET: recetas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            receta receta = db.receta.Find(id);
            if (receta == null)
            {
                return HttpNotFound();
            }
            return View(receta);
        }

        // POST: recetas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idreceta,nombre_receta,descripcion,valorReceta,ingrdientes,ubicacionReceta")] receta receta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(receta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        // GET: recetas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            receta receta = db.receta.Find(id);
            if (receta == null)
            {
                return HttpNotFound();
            }
            return View(receta);
        }

        // POST: recetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            receta receta = db.receta.Find(id);
            db.receta.Remove(receta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
