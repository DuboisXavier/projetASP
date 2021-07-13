
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
    public class ReservationController : Controller
    {
        private ReservationService _reservationService;
        private ChambreService _chambreService = new ChambreService();
        private HotelService _hotelService = new HotelService();
        private UtilisateurService _utilisateurService = new UtilisateurService();
        public ReservationController()
        {
            _reservationService = new ReservationService();
        }
        // GET: api/Reservation
        public ActionResult Index(int Id)
        {
            ReservationDetails form = new ReservationDetails();
            UtilisateurDetails utilisateur = _utilisateurService.Get(Id);
            form.UtilisateurId = SessionManager.UtilisateurDetails.Id;
            IEnumerable<ReservationListItem> reservation = _reservationService.GetByUser(Id);

            return View(reservation);
        }

        // GET: Reservation/Details/5
        public ActionResult Details(int id)
        {
            ReservationDetails reservation = _reservationService.Get(id);

            return View(reservation);
        }
        public ActionResult Create(int Id)
        {
            if (SessionManager.UtilisateurDetails != null)
            {
                ReservationDetails form = new ReservationDetails();
                ChambreDetails chambre = _chambreService.Get(Id);
                UtilisateurDetails utilisateur = _utilisateurService.Get(Id);
     
                chambre.HotelId = chambre.Numero;
                form.ChambreId = chambre.Id;
                form.UtilisateurId = SessionManager.UtilisateurDetails.Id;
                return View(form);
               

            }
            return RedirectToAction($"Index/" + SessionManager.UtilisateurDetails.Id);
        }

        // POST: Reservation/Create
        [HttpPost]
        public ActionResult Create(int id,ReservationDetails form)
        {
            if (ModelState.IsValid)
            {
                _reservationService.Insert(id, form);
            }
            return RedirectToAction($"Index/" + SessionManager.UtilisateurDetails.Id);
        }
        public ActionResult Edit(int id)
        {
            ReservationDetails hotel = _reservationService.Get(id);
            //_hotelService.Delete(id);
            return View(hotel);
        }

        //POST: Reservation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ReservationDetails form)
        {
            if (ModelState.IsValid)
            {
                _reservationService.Put(id, form);
            }
            return RedirectToAction($"Index/" + SessionManager.UtilisateurDetails.Id);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            ReservationDetails reservation = _reservationService.Get(id);
            return View(reservation);
        }

        //POST: Reservation/Delete/5

        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _reservationService.Delete(id);

                return RedirectToAction($"Index/" + SessionManager.UtilisateurDetails.Id);
            }
            catch
            {
                return View();
            }
        }
    }
}
