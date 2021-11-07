using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstApp.Models;

namespace firstApp.Controllers
{
    public class PersonalController : Controller
    {
      public IActionResult Index()
      {
          Personal personal = new Personal();
          personal.name = "Moises";
          personal.lastname = "Martinez";
          personal.age =21;
          return View(personal);
      }
    }
}