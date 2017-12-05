using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using MusicMVC.Models;
using MusicMVC.ViewModels;

namespace MusicMVC.Controllers
{
    public class MusicPlayers : Controller
    {
        private ApplicationDbContext _context;

        public MusicPlayers()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

       
        public ActionResult Index()
        {
            var musicPlayers = _context.MusicPlayers.ToList();
            return View(musicPlayers);
        }

        public ActionResult New()
        {
            var viewModel = new MusicPlayersFormViewModel
            {
                MusicPlayers = new MusicPlayer()
            };

            return View("MusicPlayersForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(MusicPlayer musicPlayers)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MusicPlayersFormViewModel
                {
                    MusicPlayers = musicPlayers
                };
                return View("MusicPlayersForm", viewModel);
            }

            if (musicPlayers.Id == 0)
            {
                _context.MusicPlayers.Add(musicPlayers);
            }
            else
            {
                var musicPlayersInDb = _context.MusicPlayers.Single(c => c.Id == musicPlayers.Id);

                musicPlayersInDb.Name = musicPlayers.Name;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var musicPlayers = _context.MusicPlayers.SingleOrDefault(c => c.Id == id);

            if (musicPlayers == null)
                return HttpNotFound();

            var viewModel = new MusicPlayersFormViewModel
            {
                MusicPlayers = musicPlayers
            };

            return View("MusicPlayersForm", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var musicPlayer = _context.MusicPlayers.SingleOrDefault(c => c.Id == id);

            if (musicPlayer == null)
                return HttpNotFound();

            _context.MusicPlayers.Remove(musicPlayer);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}