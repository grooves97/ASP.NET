using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.DataAccess;

namespace WebApplication5.Controllers
{
    public class PeopleDefaultController : Controller
    {
        // GET: PeopleDefault
        public ActionResult Index()
        {
            return View();
        }

        // GET: PeopleDefault
        [OutputCache(Duration = 100500)]
        public ActionResult All()
        {
            using(var context = new Context())
            {
                var people = context.People.ToList();

                // 1)Первый способ (не безопасный)
                ViewBag.People = people;

                // 2)Второй способ
                ViewData["People"] = people;
            }

            return View();
        }

        // GET: PeopleDefault/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PeopleDefault/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeopleDefault/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleDefault/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeopleDefault/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleDefault/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PeopleDefault/Delete/5
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
