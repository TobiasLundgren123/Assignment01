using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        //private DateTime _returnDate = DateTime.MinValue;
        //public DateTime ReturnDate
        //{
        //    get
        //    {
        //        return (_returnDate == DateTime.MinValue) ? DateTime.Now() : _returnDate;
        //    }
        //    set { _returnDate = value; }
        //}

    }
}
