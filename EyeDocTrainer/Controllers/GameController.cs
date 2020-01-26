using EyeDocTrainer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace EyeDocTrainer.Controllers
{
    public class GameController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Scene(string pathToScene)
        {
            if (String.IsNullOrEmpty(pathToScene))
            {
                return BadRequest("path to scene not set");
            }
            var fullPath = $"Data/{pathToScene}.json";
            var jsonData = System.IO.File.ReadAllText(fullPath);
            var model = JsonConvert.DeserializeObject<Scene>(jsonData);
            return View(model);
        }

        public IActionResult GameOver()
        {
            return View();
        }

        public IActionResult GameFinish()
        {
            return View();
        }
    }
}
