
using ProjetASP.MVC.Infrasctucture;
using ProjetASP.MVC.Models;
using ProjetASP.MVC.Models.forms;
using ProjetASP.MVC.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace ProjetASP.MVC.Controllers
{
    public class AuthController : Controller
    {
        private UtilisateurService _utilisateurService;
        public AuthController()
        {
            _utilisateurService = new UtilisateurService();
        }
        // GET: Auth
        public ActionResult Index()
        {
            return RedirectToAction(nameof(Login));
        }


        [HttpGet]
        //[Route("Login")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //[Route("Login")]
        public ActionResult Login(LoginForm loginForm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SessionManager.UtilisateurDetails = _utilisateurService.Login(loginForm.AdresseMail, loginForm.MotDePasse);
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {
                    return View(loginForm);
                }
            }

            return View(loginForm);
        }
        [HttpGet]
        //[Route("Login")]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        //[Route("Login")]
        public ActionResult Register(RegisterForm registerForm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UtilisateurDetails user = _utilisateurService.Register(registerForm);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    return View(registerForm);
                }
            }

            return View(registerForm);
        }
        public ActionResult Logout()
        {
            SessionManager.Abandon();
            return RedirectToAction("Index", "Home");
        }



        //public ActionResult Login()
        //{
        //    return View();
        //}

        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult Login(LoginForm form)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                try
        //                {
        //                    //Contacter ma DB
        //                    IConnection connection = new Connection(SqlClientFactory.Instance, ConfigurationManager.ConnectionStrings["DemoAsp"].ConnectionString);
        //                    Command command = new Command("CheckUser", true);
        //                    command.AddParameter("Email", form.Email);
        //                    command.AddParameter("Passwd", form.Passwd);

        //                    User user = connection.ExecuteReader(command, dr => new User()
        //                    {
        //                        Id = (int)dr["Id"],
        //                        LastName = (string)dr["LastName"],
        //                        FirstName = (string)dr["FirstName"],
        //                        Email = (string)dr["Email"],
        //                        Role = (RoleUser)dr["Role"]
        //                    }).SingleOrDefault();

        //                    if (user is null)
        //                    {
        //                        ModelState.AddModelError("", "Erreur de login ou de mot de passe!");
        //                        return View(form);
        //                    }
        //                    else
        //                    {
        //                        SessionManager.User = user;
        //                    }

        //                    return RedirectToAction("Index", "Home");
        //                }
        //                catch (Exception ex)
        //                {
        //#if DEBUG
        //                    throw ex;
        //#else
        //                    return View("Error");
        //#endif
        //                }
        //            }

        //            return View(form);
        //        }

        //public ActionResult Register()
        //{
        //    return View();
        //}

        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public ActionResult Register(RegisterForm form)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                try
        //                {
        //                    //Contacter ma DB
        //                    IConnection connection = new Connection(SqlClientFactory.Instance, ConfigurationManager.ConnectionStrings["DemoAsp"].ConnectionString);
        //                    Command command = new Command("RegisterUser", true);
        //                    command.AddParameter("LastName", form.LastName);
        //                    command.AddParameter("FirstName", form.FirstName);
        //                    command.AddParameter("Email", form.Email);
        //                    command.AddParameter("Passwd", form.Passwd);

        //                    connection.ExecuteNonQuery(command);

        //                    return RedirectToAction(nameof(Login));
        //                }
        //                catch (Exception ex)
        //                {
        //#if DEBUG
        //                    throw ex;
        //#else
        //                    return View("Error");
        //#endif
        //                }
        //            }

        //            return View(form);
        //        }

        //        public ActionResult Logout()
        //        {
        //            SessionManager.Abandon();
        //            return RedirectToAction("Index", "Home");
        //        }
    }

}
