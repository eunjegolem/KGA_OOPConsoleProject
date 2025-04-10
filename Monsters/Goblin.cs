using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    class Goblin : Monster
    {
        public Goblin(Vector2 position)
            : base('G', position)
        {
            name = "고블린";
            
        }

        public override void Attack()
        {
            
        }
    }
}
