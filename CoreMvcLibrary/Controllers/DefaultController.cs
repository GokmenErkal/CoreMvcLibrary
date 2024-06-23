using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoreMvcLibrary.Models;

namespace Asp.net_Core_MVC_Dersleri.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Books>()
            {
                new Books(){ID=1,BookName="Satranç",Writer="Zweig"},
                new Books(){ID=2,BookName="Dr Ox'un Deneyi",Writer="Jules Verne"},
                new Books(){ID=3,BookName="DeliFişek",Writer="Vasconceulos"},
                new Books(){ID=4,BookName="Kırmızı Bisiklet",Writer="Muzaffer İzgü"},
                new Books(){ID=5,BookName="Toros Canavarı",Writer="Aziz Nesin"},
            };
            return View(books);
        }
        public IActionResult Layout()
        {
            return View();
        }
        public IActionResult Deneme()
        {
            return View();
        }

        public IActionResult StatikTema()
        {
            return View();
        }
    }
}
