
using ProjetASP.MVC.Models;
using ProjetASP.MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetASP.MVC.Controllers
{
    public class RoleController : Controller
    {
        private RoleService _roleService;
        public RoleController()
        {
            _roleService = new RoleService();
        }
        // GET: api/Role
        public ActionResult Index()
        {
            IEnumerable<RoleListItem> role = _roleService.Get();

            return View(role);
        }
        public ActionResult Details(int id)
        {
            RoleDetails role = _roleService.Get(id);

            return View(role);
        }
        public ActionResult Create()
        {
            RoleDetails form = new RoleDetails();

            return View(form);
        }

        // POST: Role/Create
        [HttpPost]
        public ActionResult Create(RoleDetails form)
        {
            if (ModelState.IsValid)
            {
                _roleService.Insert(form);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            RoleDetails role = _roleService.Get(id);
            //_hotelService.Delete(id);
            return View(role);
        }

        //POST: Role/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, RoleDetails form)
        {
            if (ModelState.IsValid)
            {
                _roleService.Put(id, form);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            RoleDetails role = _roleService.Get(id);
            //_hotelService.Delete(id);
            return View(role);
        }

        //POST: Hotel/Delete/5

        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _roleService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
