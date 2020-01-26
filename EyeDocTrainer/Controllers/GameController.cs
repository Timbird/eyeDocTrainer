using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EyeDocTrainer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EyeDocTrainer.Controllers
{
    public class GameController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Scene(string? pathToScene)
        {
            Scene model = new Scene();

            File(pathToScene);
            Scene model = JsonConvert.DeserializeObject<Scene>(pathToScene);
            //if (model.Description == null)
            //{
            //    var decision1 = new Decision
            //    {
            //        Text = "use glue",
            //        WillFail = true
            //    };
            //    var decision2 = new Decision
            //    {
            //        Text = "use ALL the glue",
            //        WillFail = false
            //    };
            //    model = new Scene
            //    {
            //        Timer = 0,
            //        Description = "This is the first decision",
            //        Decisions = new List<Decision>()
            //    };
            //    model.Decisions.Add(decision1);
            //    model.Decisions.Add(decision2);
            //}

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
