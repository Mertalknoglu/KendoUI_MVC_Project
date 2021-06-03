using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Deployment.Internal;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KendoUIProject;
using KendoUIProject.Models;

namespace KendoUIProject.Controllers
{
    public class menusController : Controller
    {
        private TaskProjectEntities db = new TaskProjectEntities();

        //// GET: menus
        //public ActionResult Index()
        //{
        //    return View(db.menus.ToList());
        //}
       
       
        //// GET: menus/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    menus menus = db.menus.Find(id);
        //    if (menus == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(menus);
        //}

        //// GET: menus/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: menus/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "id,parentid,title,link")] menus menus)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.menus.Add(menus);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(menus);
        //}

        //// GET: menus/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    menus menus = db.menus.Find(id);
        //    if (menus == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(menus);
        //}

        //// POST: menus/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "id,parentid,title,link")] menus menus)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(menus).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(menus);
        //}

        //// GET: menus/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    menus menus = db.menus.Find(id);
        //    if (menus == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(menus);
        //}

        //// POST: menus/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    menus menus = db.menus.Find(id);
        //    db.menus.Remove(menus);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);

        //}



    }
}
