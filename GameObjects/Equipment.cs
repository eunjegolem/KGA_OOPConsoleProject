using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Equipments
{
    public abstract class Equipment : Item
    {
        public string name;
        public string description;
        public int price;

        public Equipment(char symbol, Vector2 position, int price)
            : base(symbol, position, price)
        {
            this.price = price;
        }
        public override void Interact(Player player)
        {
            player.Inventory.Add(this);
        }
    }
}
