using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeros.Controllers
{
    public class SuperController : Controller
    {
        // GET: SuperController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: SuperController/Edit/5
        public ActionResult Edit(int id)
        {
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
