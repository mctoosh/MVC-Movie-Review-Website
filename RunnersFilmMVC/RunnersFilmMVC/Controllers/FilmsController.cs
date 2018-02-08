using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RunnersFilmMVC.Models;
using PagedList;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace RunnersFilmMVC.Controllers
{
    public class FilmsController : Controller
    {
        private RunnerContext db = new RunnerContext();

        // GET: Films
        public ActionResult Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            //this code makes sure the user is logged in before he can delete, add, or edit.
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());

            string email = "not logged in";

            if (user != null)
            {

                email = user.Email;

            }

            ViewBag.email = email;

            //this code lets the user to sort the films and the ratings for the films
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.NumSortParm = sortOrder == "Num" ? "num_desc" : "Num";

            //this code is used to make pages for the films webpage
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            //this code gets data from the database
            var students = from s in db.Films
                           select s;
            //this code searches for movies or genres from the database
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Movie.Contains(searchString) || s.Genre.genre.Contains(searchString));
            }
            //this code orders the sorting from decending to ascendeing
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(f => f.Movie);
                    break;
                case "Num":
                    students = students.OrderBy(s => s.Rating);
                    break;
                case "num_desc":
                    students = students.OrderByDescending(s => s.Rating);
                    break;
                default:
                    students = students.OrderBy(f => f.Movie);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            //this code displays all the data on to the browser
            var films = db.Films.Include(f => f.Actor).Include(f => f.Director).Include(f => f.Genre);
            return View(students.ToPagedList(pageNumber, pageSize));
        }

        // GET: Films/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Films/Create
        public ActionResult Create()
        {
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "Name");
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "Name");
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "genre");
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmId,Movie,Year,Description,Duration,Rating,GenreId,ActorId,DirectorId")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "Name", film.ActorId);
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "Name", film.DirectorId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "genre", film.GenreId);
            return View(film);
        }

        // GET: Films/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "Name", film.ActorId);
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "Name", film.DirectorId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "genre", film.GenreId);
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmId,Movie,Year,Description,Duration,Rating,GenreId,ActorId,DirectorId")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "Name", film.ActorId);
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "Name", film.DirectorId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "genre", film.GenreId);
            return View(film);
        }

        // GET: Films/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Films.Find(id);
            db.Films.Remove(film);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
