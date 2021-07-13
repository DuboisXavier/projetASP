using ProjetASP.MVC.Models;
using ProjetASP.MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetASP.MVC.Controllers
{
    public class AdresseController : Controller
    {
        private AdresseService _adresseService;
        public AdresseController()
        {
            _adresseService = new AdresseService();
        }
        // GET: Hotel
        public ActionResult Index()
        {
            IEnumerable<AdresseListItem> adresse = _adresseService.Get();

            return View(adresse);
        }
        // GET: Adresse


        // GET: Adresse/Details/5
        public ActionResult Details(int id)
        {
            AdresseDetails role = _adresseService.Get(id);

            return View(role);
        }

        // GET: Adresse/Create
        public ActionResult Create()
        {
            AdresseDetails form = new AdresseDetails();

            return View(form);
        }

        // POST: Adresse/Create
        [HttpPost]
        public ActionResult Create(AdresseDetails form)
        {
            if (ModelState.IsValid)
            {
                _adresseService.Insert(form);
            }
            return RedirectToAction("Index");
        }

        // GET: Adresse/Edit/5
        public ActionResult Edit(int id)
        {
            AdresseDetails role = _adresseService.Get(id);
            
            return View(role);
        }

        //POST: Adresse/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AdresseDetails form)
        {
            if (ModelState.IsValid)
            {
                _adresseService.Put(id, form);
            }
            return RedirectToAction("Index");
        }

        // GET: Adresse/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            AdresseDetails role = _adresseService.Get(id);
            //_adresseService.Delete(id);
            return View(role);
        }

        //POST: Adresse/Delete/5

        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _adresseService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
