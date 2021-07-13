
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
    public class HotelController : Controller
    {
        private HotelService _hotelService;
        public HotelController()
        {
            _hotelService = new HotelService();
        }
        // GET: Hotel
        public ActionResult Index()
        {
            IEnumerable<HotelListItem> hotel = _hotelService.Get();

            return View(hotel);
        }

        // GET: Hotel/Details/5
        public ActionResult Details(int id)
        {
            HotelDetails hotel = _hotelService.Get(id);

            return View(hotel);
        }

        // GET: Hotel/Create
        public ActionResult Create()
        {
            HotelDetails form = new HotelDetails();

            return View(form);
        }

        // POST: Hotel/Create
        [HttpPost]
        public ActionResult Create(HotelDetails form)
        {
            if (ModelState.IsValid)
            {
                _hotelService.Insert(form);
            }
            return RedirectToAction("Index");
        }

        //GET: Hotel/Edit/5
        public ActionResult Edit(int id)
        {

            HotelDetails hotel = _hotelService.Get(id);
            //_hotelService.Delete(id);
            return View(hotel);
        }

        //POST: Hotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, HotelDetails form)
        {
            if (SessionManager.UtilisateurDetails != null)
            {
                if (SessionManager.IsAdmin)
                {
                    if (ModelState.IsValid)
                    {
                        _hotelService.Put(id, form);
                    }
                    
                }
            }
            return RedirectToAction("Index");
        }

        // GET: Hotel/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            HotelDetails hotel = _hotelService.Get(id);
            //_hotelService.Delete(id);
            return View(hotel);
        }

        //POST: Hotel/Delete/5
        
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {              
                _hotelService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
