using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WareHouse.Repositories;

namespace WareHouse.Controllers
{
    [Route("")]
    public class ClothController : Controller
    {
        private ClothRepository ClothRepository;

        public ClothController(ClothRepository clothRepository)
        {
            ClothRepository = clothRepository;
        }

        [HttpGet]
        [Route("/warehouse")]
        public IActionResult Index()
        {
            return View(ClothRepository.GetList());
        }

        //[HttpPost]
        //[Route("/warehouse/summary")]
        //public IActionResult Summary()
        //{
        //    //return View(Summary);
        //}

        [HttpGet]
        [Route("/warehouse/query")]
        public IActionResult ApiSearch(int price)
        {
            return Json(new { result = "ok", clothes = ClothRepository.FilterAmmount(price)});
        }
    }
}