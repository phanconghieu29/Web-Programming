using Question2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Question2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SongInformation()
        {
            QL_BaiHatEntities1 db = new QL_BaiHatEntities1();
            List<tbl_BaiHat> songs = db.tbl_BaiHat.ToList();
            return View(songs);
        }

        public ActionResult GenreInformation()
        {
            QL_BaiHatEntities1 db = new QL_BaiHatEntities1();
            List<tbl_TheLoai> genres = db.tbl_TheLoai.ToList();
            return View(genres);
        }

        public ActionResult AddNewGenre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewGenre(tbl_TheLoai genre)
        {
            QL_BaiHatEntities1 db = new QL_BaiHatEntities1();
            db.tbl_TheLoai.Add(genre);
            db.SaveChanges();
            return RedirectToAction("GenreInformation");
        }
    }
}