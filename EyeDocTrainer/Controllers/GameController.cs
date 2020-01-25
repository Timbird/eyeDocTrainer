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
        
        public IActionResult Scene(Scene model = null)
        {
            if(model.Description == null)
            {
                var decision1 = new Decision
                {
                    Text = "use glue",
                    WillFail = true
                };
                var decision2 = new Decision
                {
                    Text = "use ALL the glue",
                    WillFail = false
                };
                model = new Scene
                {
                    Timer = 0,
                    NextSceneLink = Url.Action("GameFinish", "Game"),
                    Description = "This is the first decision",
                    Decisions = new List<Decision>()
                };
                model.Decisions.Add(decision1);
                model.Decisions.Add(decision2);
            }
            
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
