using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopMyPham.Models;

namespace ShopMyPham.Controllers
{
    public class ClientController : Controller
    {
        private readonly ShopMyPhamEntities db = new ShopMyPhamEntities();
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(QuanTriModel model)
        {
            var user = db.QuanTris.SingleOrDefault(x => x.Username.Equals(model.Username) && x.Password.Equals(model.Password));
            if (user != null)
            {
                Session["user"] = new QuanTri {ID = user.ID, Username = model.Username, Ten = user.Ten, DiaChi = user.DiaChi, Sdt = user.Sdt };
                return RedirectToAction("Index","Home",Session["user"]);
            }
            return View("Index");
        }

        public ActionResult Logout()
        {
            Session["user"] = null;
            return RedirectToAction("Index", "Home");
           // return View();
        }
        public ActionResult Register(QuanTriModel model)
        {
            QuanTri qt = new QuanTri()
            {
                Username = model.Username,
                Password = model.Password,
                TrangThai = false,
                Email = model.Email
            };
            if(ModelState.IsValid)
            {
                db.QuanTris.Add(qt);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}