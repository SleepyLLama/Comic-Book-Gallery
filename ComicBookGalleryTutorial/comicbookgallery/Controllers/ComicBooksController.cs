using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace comicbookgallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public string Detail()
        {
            return "hello for the details action in the comic books controller! XD";
        }
    }
}
