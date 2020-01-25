using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EyeDocTrainer.Models
{
    public class Decision
    {
        public string? Text { get; set; }
        public bool WillFail { get; set; }
        public int? NextSceneID { get; set; }
    }
}
