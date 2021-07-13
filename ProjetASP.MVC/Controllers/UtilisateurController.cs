
using ProjetASP.MVC.Infrasctucture;
using ProjetASP.MVC.Models;
using ProjetASP.MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetASP.MVC.Controllers
{
    public class UtilisateurController : Controller
    {
        private UtilisateurService _utilisateurService;
        public UtilisateurController()
        {
            _utilisateurService = new UtilisateurService();
        }
        // GET: Hotel
        public ActionResult Index()
        {
             
            IEnumerable<UtilisateurListItem> utilisateur = _utilisateurService.Get();
            return View(utilisateur);
        
        }

        // GET: Hotel/Details/5
        public ActionResult Details(int id)
        {
            UtilisateurDetails utilisateur = _utilisateurService.Get(id);

            return View(utilisateur);
        }

        //GET: Hotel/Create
       // public ActionResult Register()
       // {
       //     UtilisateurDetails form = new UtilisateurDetails();

       //     return View(form);
       // }

       // POST: Hotel/Create
       //[HttpPost]
       // public ActionResult Register(UtilisateurDetails form)
       // {
       //     if (ModelState.IsValid)
       //     {
       //         _utilisateurService.Insert(form);
       //     }
       //     return RedirectToAction("Index");
       // }

        //GET: Hotel/Edit/5
        public ActionResult Edit(int id)
        {
            UtilisateurDetails utilisateur = _utilisateurService.Get(id);
            //_hotelService.Delete(id);
            return View(utilisateur);
        }

        //POST: Hotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UtilisateurDetails form)
        {
            if (ModelState.IsValid)
            {
                _utilisateurService.Put(id, form);
            }
            return RedirectToAction("Index");
        }

        // GET: Hotel/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            UtilisateurDetails utilisateur = _utilisateurService.Get(id);
            //_hotelService.Delete(id);
            return View(utilisateur);
        }

        //POST: Hotel/Delete/5

        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _utilisateurService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
