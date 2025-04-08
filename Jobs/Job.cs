using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    abstract class Job
    {
        public abstract string jobname { get; }
        public abstract int hp { get; }
        public abstract int mp { get; } 
        public abstract int str { get; } 
        public abstract int agi { get; } 
        public abstract int vit { get; } 
        public abstract int dex { get; } 
        public abstract int intel { get; } 
        public abstract int luk { get; } 
        public abstract int cham { get;} 
    }
}
