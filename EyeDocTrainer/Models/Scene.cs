using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EyeDocTrainer.Models
{
    public class Scene
    {
        public int Timer { get; set; }
        public string Description { get; set; }
        public List<Decision> Decisions { get; set; }
        public string NextSceneLink { get; set; }
    }
}
