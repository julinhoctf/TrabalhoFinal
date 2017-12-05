using MusicMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicMVC.ViewModels;

namespace MusicMVC.Controllers
{
	public class MusicsController : Controller
	{
		private ApplicationDbContext _context;

		public MusicsController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		
		
		public ActionResult Random()
		{
			
			var music = new Music() { Name = "Highway To Hell" };

			var customers = new List<Customer>
			{
				new Customer{Name = "Customer 1"},
				new Customer{Name = "Customer 2"}
			};

			var viewModel = new RandoMusicViewModel
			{
				Music = music,
				Customers = customers
			};

			return View(viewModel);
		}



		public ActionResult Index()
		{
			var music = _context.Musics.ToList();

			return View(music);
		}

		public ActionResult New()
		{
			var viewModel = new MusicsFormViewModel
			{
				Music = new Music()
			};

			return View("MusicForm", viewModel);
		}

		[HttpPost]
		public ActionResult Save(Music music)
		{
			if (!ModelState.IsValid)
			{
				var viewModel = new MusicsFormViewModel
				{
					Music = music
				};
				return View("MusicForm", viewModel);
			}

			if (music.Id == 0)
			{
				_context.Musics.Add(music);
			}
			else
			{
				var MusicInDb = _context.Musics.Single(c => c.Id == music.Id);

				MusicInDb.Name = music.Name;
			}
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Edit(int id)
		{
			var music = _context.Musics.SingleOrDefault(c => c.Id == id);

			if (music == null)
				return HttpNotFound();

			var viewModel = new MusicsFormViewModel
			{
				Music = music
			};

			return View("MusicsForm", viewModel);
		}

		public ActionResult Delete(int id)
		{
			var music = _context.Musics.SingleOrDefault(c => c.Id == id);

			if (music == null)
				return HttpNotFound();

			_context.Musics.Remove(music);

			return new HttpStatusCodeResult(200);
		}
	}
}