using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EyeDocTrainer.Models
{
    public class Decision
    {
        public string? Text { get; set; }
        public bool WillPass { get; set; }
        public string? NextScene { get; set; }
        public int TimeTaken { get; set; }

        public string FailureReason { get; set; }
    }
}
