using CoreMvcLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreMvcLibrary.ViewComponents
{
    public class NewBooks : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var bookList = new List<Books>
            {
                new Books(){ID=6,BookName="Korku",Writer="Zweig"},
                new Books(){ID=7,BookName="Ann Karanina",Writer="Tolstoy"},
            };

            return View(bookList);
        }
    }
}
