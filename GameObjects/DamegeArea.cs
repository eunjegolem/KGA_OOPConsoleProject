using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public abstract class DamegeArea : GameObject
    {
        public string name;
        public string description;

        public DamegeArea(char symbol, Vector2 position, bool isOnce) : base(ConsoleColor.Red, symbol, position, isOnce)
        {
           
        }

        public override void Interact(Player player)
        {
            
        }
    }
}
