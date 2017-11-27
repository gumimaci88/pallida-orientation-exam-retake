using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WareHouse.Repositories;
using WareHouse.Models;

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

        [HttpPost]
        [Route("/warehouse/summary")]
        public IActionResult Summary()
        {
            return View();
        }

        [HttpGet]
        [Route("/warehouse/query")]
        public IActionResult CompareItems([FromQuery]int price, [FromQuery]string type)
        {
            if (type == "equal")
            {
                return Json(new { result = "ok", clothes = ClothRepository.FilterEqual(price) });
            }

            else if (type == "higher")
            {
                return Json(new { result = "ok", clothes = ClothRepository.FilterHigher(price) });
            }

            else (type == "lower")
            {
                return Json(new { result = "ok", clothes = ClothRepository.FilterLower(price) });
            }
        }
    }
}
    