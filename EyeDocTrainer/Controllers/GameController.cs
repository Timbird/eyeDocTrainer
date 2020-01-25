using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EyeDocTrainer.Models;
using Microsoft.AspNetCore.Mvc;

namespace EyeDocTrainer.Controllers
{
    public class GameController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Scene()
        {
            var model = new Scene();
            return View(model);
        }

        public IActionResult Scene(Scene scene)
        {
            return View(scene);
        }
    }
}
