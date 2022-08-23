using MVC.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class trabajdoresController : Controller
    {
        private restauranteEntities1 db = new restauranteEntities1();

        // GET: trabajdores
        public ActionResult Index()
        {
            return View(db.trabajdores.ToList());
        }

        // GET: trabajdores/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            trabajdores trabajdores = db.trabajdores.Find(id);
            if (trabajdores == null)
            {
                return HttpNotFound();
            }
            return View(trabajdores);
        }

        // GET: trabajdores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: trabajdores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtrabajador,tipoDocumento,nomtrabajador,dirTrabajador,telTrabajdor,celTrabajador")] trabajdores trabajdores)
        {
            if (ModelState.IsValid)
            {
                db.trabajdores.Add(trabajdores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trabajdores);
        }

        // GET: trabajdores/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            trabajdores trabajdores = db.trabajdores.Find(id);
            if (trabajdores == null)
            {
                return HttpNotFound();
            }
            return View(trabajdores);
        }

        // POST: trabajdores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtrabajador,tipoDocumento,nomtrabajador,dirTrabajador,telTrabajdor,celTrabajador")] trabajdores trabajdores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trabajdores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trabajdores);
        }

        // GET: trabajdores/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            trabajdores trabajdores = db.trabajdores.Find(id);
            if (trabajdores == null)
            {
                return HttpNotFound();
            }
            return View(trabajdores);
        }

        // POST: trabajdores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            trabajdores trabajdores = db.trabajdores.Find(id);
            db.trabajdores.Remove(trabajdores);
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
        public ActionResult Trabajador()
        {
            return View();
        }
    }

}
