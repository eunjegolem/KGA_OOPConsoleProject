using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Jobs
{
    class Warrior : Job
    {
        public override string jobname => "전사";

        public override int hp => 100;

        public override int mp => 20;

        public override int str => 6;

        public override int agi => 3;

        public override int vit => 8;

        public override int dex => 2;

        public override int intel => 2;

        public override int luk => 3;

        public override int cham => 3;
    }
}
