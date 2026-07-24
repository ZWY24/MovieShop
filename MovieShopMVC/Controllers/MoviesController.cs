using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult Details(int id)
        {
            var movieDetails = _movieService.GetMovieDetails(id);
            return View(movieDetails);
        }
        
    }
}


