using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint4.Controllers
{
    public class PswdGeneratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
