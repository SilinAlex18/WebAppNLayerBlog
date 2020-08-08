using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAppNLayerBlog.BusinessLogicLayer.IRepositories;
using WebAppNLayerBlog.Models;

namespace WebAppNLayerBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGuestManager _guestManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IGuestManager guestManager, ILogger<HomeController> logger)
        {
            _guestManager = guestManager;
            _logger = logger;
        }

        public IActionResult Index(string searchString, int? pageNumber)
        {
            ViewData["currentFilter"] = searchString;

            int pageSize = 1;

            var guest = _guestManager.GetGuestIndex();

            if (!String.IsNullOrEmpty(searchString))
            {
                guest = _guestManager.GetGuestSearch(searchString);
            }

            return View(_guestManager.GuestPaging(pageNumber ?? 1, pageSize));
        }

        public IActionResult Detail(int id)
        {
            var guest = _guestManager.GetGuestDetail(id);
            return View(guest);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
