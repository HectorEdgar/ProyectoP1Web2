﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoP1Web2.Models;

namespace ProyectoP1Web2.Controllers
{
    [Authorize]
    public class catalogocoordsController : Controller
    {
        private SistemaGimnasioEntities db = new SistemaGimnasioEntities();

        // GET: catalogocoords
        public async Task<ActionResult> Index()
        {
            return View(await db.catalogocoord.ToListAsync());
        }

        // GET: catalogocoords/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            catalogocoord catalogocoord = await db.catalogocoord.FindAsync(id);
            if (catalogocoord == null)
            {
                return HttpNotFound();
            }
            return View(catalogocoord);
        }

        // GET: catalogocoords/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: catalogocoords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "clavecct,nombre,latitud,longitud,lada,telefono,email")] catalogocoord catalogocoord)
        {
            if (ModelState.IsValid)
            {
                db.catalogocoord.Add(catalogocoord);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(catalogocoord);
        }

        // GET: catalogocoords/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            catalogocoord catalogocoord = await db.catalogocoord.FindAsync(id);
            if (catalogocoord == null)
            {
                return HttpNotFound();
            }
            return View(catalogocoord);
        }

        // POST: catalogocoords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "clavecct,nombre,latitud,longitud,lada,telefono,email")] catalogocoord catalogocoord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catalogocoord).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(catalogocoord);
        }

        // GET: catalogocoords/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            catalogocoord catalogocoord = await db.catalogocoord.FindAsync(id);
            if (catalogocoord == null)
            {
                return HttpNotFound();
            }
            return View(catalogocoord);
        }

        // POST: catalogocoords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            catalogocoord catalogocoord = await db.catalogocoord.FindAsync(id);
            db.catalogocoord.Remove(catalogocoord);
            await db.SaveChangesAsync();
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
