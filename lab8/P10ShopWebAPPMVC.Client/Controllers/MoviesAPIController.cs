using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
// using P06Shop.Shared.Services.ProductService;
// using P06Shop.Shared.Shop;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.MovieCollection;


namespace P09ShopWebAPPMVC.Client.Controllers
{
    public class MoviesAPIController : Controller
    {
      
        private readonly IMovieService _movieService;

        public MoviesAPIController(IMovieService movieService)
        {
            _movieService = movieService;
          
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetMoviesAsync();
            return movies != null ?
                          View(movies.Data.AsEnumerable()) :
                          Problem("Entity set 'MovieCollection.Movies'  is null.");

            //return products != null ? 
            //              View("~/Views/Products/Index.cshtml", products.Data.AsEnumerable()) :
            //              Problem("Entity set 'ShopContext.Products'  is null.");
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
         
            if (id == null)
            {
                return NotFound();
            }
            var movie = await _movieService.GetMovieByIdAsync((int)id);
            
            if (movie.Data == null)
            {
                return NotFound();
            }

            return View(movie.Data);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Genre,LengthInMinutes,ReleaseDate,CountryOfOrigin,Director")] Movie movie)
        {
             
            if (ModelState.IsValid)
            {
                await _movieService.CreateMovieAsync(movie);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _movieService.GetMovieByIdAsync((int)id);
            if (movie.Data == null)
            {
                return NotFound();
            }
            return View(movie.Data);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Genre,LengthInMinutes,ReleaseDate,CountryOfOrigin,Director")] Movie movie)
        {

            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var movieResult = await _movieService.UpdateMovieAsync(movie);
                }
                catch (Exception)
                {
                     return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var movie = await _movieService.GetMovieByIdAsync((int)id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie.Data);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _movieService.DeleteMovieAsync((int)id);
            if (movie.Success)
                return RedirectToAction(nameof(Index));
            else
                return NotFound();
          
        }
         
    }
}
