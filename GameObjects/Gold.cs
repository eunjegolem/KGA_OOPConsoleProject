using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KGA_OOPConsoleProject.Maps
{
    public class Gold : GameObject
    {
        string name = "골드";
        string description = "재화";
        int    price = 1;
        public Gold(Vector2 position)
            : base(ConsoleColor.Yellow, 'G', position, true)
        {
            name = "골드";
            description = "재화";
            price = 1;
        }

        public override void Interact(Player player)
        {
            Game.Player.gold += 100;
        }
    }
}
