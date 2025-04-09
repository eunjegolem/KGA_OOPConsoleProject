using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KGA_OOPConsoleProject.Maps
{
    public class Gold : Item
    {
        public Gold(Vector2 position)
            : base('G', position, 1)
        {
            name = "골드";
            description = "재화";
            price = 1;
        }

        public override void Use()
        {

        }
    }
}
