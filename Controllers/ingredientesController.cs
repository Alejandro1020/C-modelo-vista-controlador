using MVC.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ingredientesController : Controller
    {
        private restauranteEntities1 db = new restauranteEntities1();

        // GET: ingredientes
        public ActionResult Index()
        {
            return View(db.ingredientes.ToList());
        }

        // GET: ingredientes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingredientes ingredientes = db.ingredientes.Find(id);
            if (ingredientes == null)
            {
                return HttpNotFound();
            }
            return View(ingredientes);
        }

        // GET: ingredientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ingredientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idIngrediente,tipoIngrediente,nomIngrediente,cantidad,inventario")] ingredientes ingredientes)
        {
            if (ModelState.IsValid)
            {
                db.ingredientes.Add(ingredientes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ingredientes);
        }

        // GET: ingredientes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingredientes ingredientes = db.ingredientes.Find(id);
            if (ingredientes == null)
            {
                return HttpNotFound();
            }
            return View(ingredientes);
        }

        // POST: ingredientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idIngrediente,tipoIngrediente,nomIngrediente,cantidad,inventario")] ingredientes ingredientes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingredientes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingredientes);
        }

        // GET: ingredientes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ingredientes ingredientes = db.ingredientes.Find(id);
            if (ingredientes == null)
            {
                return HttpNotFound();
            }
            return View(ingredientes);
        }

        // POST: ingredientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ingredientes ingredientes = db.ingredientes.Find(id);
            db.ingredientes.Remove(ingredientes);
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
