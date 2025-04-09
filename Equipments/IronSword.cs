using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KGA_OOPConsoleProject.Equipments
{
    class IronSword : Equipment
    {
        public IronSword(Vector2 position)
            : base('S', position, 100)
        {
            name = "철검";
            description = "장비하여 적을 공격하는 무기";
            price = 100;
        }

        public override void Use()
        {
            
        }
    }
}
