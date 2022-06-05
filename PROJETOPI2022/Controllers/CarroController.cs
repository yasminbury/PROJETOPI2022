using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJETOPI2022.Models;

namespace PROJETOPI2022.Controllers
{
    public class CarroController : Controller
    {
        // GET: CarroController
        public ActionResult Carro()
        {
            return View();
        }

        // GET: CarroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarroController/Create
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

        // GET: CarroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarroController/Edit/5
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

        // GET: CarroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarroController/Delete/5
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
