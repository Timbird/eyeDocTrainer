using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EyeDocTrainer.Models
{
    public class Scene
    {
        public string Name {get;set;}
        public int Timer { get; set; }
        public string Description { get; set; }
        public string? LinkToImage { get; set; }
        public List<Decision> Decisions { get; set; }
    }
}
