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
        [Route("/")]
        public IActionResult Index()
        {
            return View(ClothRepository.GetList());
        }
    }
}
//        [HttpGet]
//        GET /warehouse

//        [HttpPost]

//        [HttpGet]

//            POST /warehouse/summary

//            GET /warehouse/query
//    }
//}
