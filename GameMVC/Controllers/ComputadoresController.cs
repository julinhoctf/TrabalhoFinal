using MusicMVC.Models;
using MusicMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicMVC.Controllers
{
    public class ComputadoresController : Controller
    {
        private ApplicationDbContext _context;

        public ComputadoresController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Computador
        public ActionResult Index()
        {
            var computadores = _context.Computadores.ToList();

            return View(computadores);
            
        }

        public ActionResult New()
        {
            var viewModel = new PlataformssFormViewModel
            {
                Plataform = new Plataform()
            };

            return View("ComputadorForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Plataform computador)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PlataformssFormViewModel
                {
                    Plataform = computador
                };
                return View("ComputadorForm", viewModel);
            }

            if (computador.Id == 0)
            {
                _context.Computadores.Add(computador);
            }
            else
            {
                var computadorInDb = _context.Computadores.Single(c => c.Id == computador.Id);

                computadorInDb.Name = computador.Name;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var computador = _context.Computadores.SingleOrDefault(c => c.Id == id);

            if (computador == null)
                return HttpNotFound();

            var viewModel = new PlataformssFormViewModel
            {
                Plataform = computador
            };

            return View("ComputadorForm", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var computador = _context.Computadores.SingleOrDefault(c => c.Id == id);

            if (computador == null)
                return HttpNotFound();

            _context.Computadores.Remove(computador);
            _context.SaveChanges();


            return new HttpStatusCodeResult(200);
        }
    }
}