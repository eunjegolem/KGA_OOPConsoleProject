using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public abstract class Item : GameObject
    {
        public string name;
        public string description;
        public int price;

        public Item(char symbol, Vector2 position, int price)
            : base(ConsoleColor.Yellow, symbol, position, true)
        {
            this.price = price;
        }

        public override void Interact(Player player)
        {
            player.Inventory.Add(this);
        }

        public abstract void Use();
    }
}
