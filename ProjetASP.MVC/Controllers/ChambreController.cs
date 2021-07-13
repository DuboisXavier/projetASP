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
    public class ChambreController : Controller
    {
        private ChambreService _chambreService;
        private HotelService _hotelService = new HotelService();
        
        public ChambreController()
        {
            _chambreService = new ChambreService();
        }
        //GET: Hotel
        public ActionResult Index()
        {
            ChambreDetails form = new ChambreDetails();
            IEnumerable<ChambreListItem> chambre = _chambreService.Get();

            return View(chambre);
        }
        //public ActionResult Index(int id)
        //{
        //    IEnumerable<ChambreListItem> chambre = _chambreService.GetByHotel(id);

        //    return View(chambre);
        //}

        // GET: Hotel/Create
        public ActionResult Create(int id)
        {
            if (SessionManager.UtilisateurDetails != null)
            {
                if (SessionManager.IsAdmin)
                {
                    ChambreDetails form = new ChambreDetails();
                    HotelDetails hotel = _hotelService.Get(id);
                    form.Nom = hotel.Nom;
                    form.HotelId = hotel.Id;
                    return View(form);
                }
            }
            return RedirectToAction("Index");
        }

        // POST: Hotel/Create
        [HttpPost]
        public ActionResult Create(int id,  ChambreDetails form)
        {
            if (SessionManager.UtilisateurDetails != null)
            {
                if (SessionManager.IsAdmin)
                {
                    if (ModelState.IsValid)
                    {
                        _chambreService.Insert(form);
                    }
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            ChambreDetails chambre = _chambreService.Get(id);

            return View(chambre);
        }
        //GET: Hotel/Edit/5
        public ActionResult Edit(int id)
        {
            if (SessionManager.UtilisateurDetails != null)
            {
                if (SessionManager.IsAdmin)
                {
                    ChambreDetails hotel = _chambreService.Get(id);
                    return View(hotel);
                }
            }
          
            return View();
        }

        //POST: Hotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ChambreDetails form)
        {
            if (SessionManager.UtilisateurDetails != null)
            {
                if (SessionManager.IsAdmin)
                {
                    if (ModelState.IsValid)
                    {
                        _chambreService.Put(id, form);
                    }
                }
            }
            return RedirectToAction("Index");
        }

        // GET: Chambre/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (SessionManager.UtilisateurDetails != null)
            {
                if (SessionManager.IsAdmin)
                {
                    ChambreDetails chambre = _chambreService.Get(id);
                    return View(chambre);
                }
            }
            return RedirectToAction("index");
        }

            //POST: Chambre/Delete/5

        public ActionResult Delete(int id, FormCollection collection)
        {
            if (SessionManager.UtilisateurDetails != null)
            {
                if (SessionManager.IsAdmin)
                {
                    try
                    {
                        _chambreService.Delete(id);

                        return RedirectToAction("Index");
                    }
                    catch
                    {
                        return View();
                    }
                }
            }
            return RedirectToAction("index");
        }
    }
}
