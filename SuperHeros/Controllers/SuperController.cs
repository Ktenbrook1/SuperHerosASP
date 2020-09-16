using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using SuperHeros.Data;
using SuperHeros.Models;

namespace SuperHeros.Controllers
{
    public class SuperController : Controller
    {
        ApplicationDbContext db;
        public SuperController(ApplicationDbContext context)
        {
            db = context;
        }
        // GET: SuperController
        public ActionResult Index()
        {
            // query for all the superhereos from the DB
            return View(db.SuperHeros);
        }

        // GET: SuperController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperController/Create
        public ActionResult Create()
        {
            SuperHero hero = new SuperHero();

            return View(hero);
        }

        // POST: SuperController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero hero)
        {
            try
            {
                db.SuperHeros.Add(hero);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperController/Edit/5
        public ActionResult Edit(int id)
        {
            //
            return View();
        }

        // POST: SuperController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
