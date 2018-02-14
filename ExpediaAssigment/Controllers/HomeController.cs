using System.Diagnostics;
using ExpediaAssigment.Models;
using Hotels.Models.ViewModels;
using Hotels.Services;
using Microsoft.AspNetCore.Mvc;
namespace Hotels
{
    public class HomeController : Controller
    {
        public HomeController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        private readonly IHotelService hotelService;

        public IActionResult Index()
        {
            return View(new IndexData());
        }

        [HttpPost]
        public IActionResult Index(IndexData model)
        {
            var offers = hotelService.GetOffersAsync(model.Filters).Result;

            return View(new IndexData { Offers = offers });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
