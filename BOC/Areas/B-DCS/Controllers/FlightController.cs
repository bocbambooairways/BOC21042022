using Microsoft.AspNetCore.Mvc;

namespace BOC.Areas.B_DCS.Controllers
{
   
    [Area("B-DCS")]
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult M_Index()
        {
            return View();  
        }
        public IActionResult M_FlightList()
        {
            return View();
        }
        public IActionResult M_SearchList()
        {
            return View();
        }
        public IActionResult M_Passenger()
        {
            return View();
        }
        public IActionResult M_PassengerList()
        {
            return View();
        }
        public IActionResult M_Comment()
        {
            return View();
        }
    }
}
