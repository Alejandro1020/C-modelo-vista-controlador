using MVC.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class comenzalesController : Controller
    {
        private restauranteEntities1 db = new restauranteEntities1();

        // GET: comenzales
        public ActionResult Index()
        {
            return View(db.comenzales.ToList());
        }

        // GET: comenzales/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comenzales comenzales = db.comenzales.Find(id);
            if (comenzales == null)
            {
                return HttpNotFound();
            }
            return View(comenzales);
        }

        // GET: comenzales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: comenzales/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idcomenzal,nombreComenzal,platosDeGusto,telcomenzal")] comenzales comenzales)
        {
            if (ModelState.IsValid)
            {
                db.comenzales.Add(comenzales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comenzales);
        }

        // GET: comenzales/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comenzales comenzales = db.comenzales.Find(id);
            if (comenzales == null)
            {
                return HttpNotFound();
            }
            return View(comenzales);
        }

        // POST: comenzales/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idcomenzal,nombreComenzal,platosDeGusto,telcomenzal")] comenzales comenzales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comenzales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comenzales);
        }

        // GET: comenzales/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comenzales comenzales = db.comenzales.Find(id);
            if (comenzales == null)
            {
                return HttpNotFound();
            }
            return View(comenzales);
        }

        // POST: comenzales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            comenzales comenzales = db.comenzales.Find(id);
            db.comenzales.Remove(comenzales);
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
