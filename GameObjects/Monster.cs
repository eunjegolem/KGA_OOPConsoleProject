using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public abstract class Monster : GameObject
    {
        public string name;
        public int hp;
        public int str; 

        public Monster(char symbol, Vector2 position)
            : base(ConsoleColor.DarkMagenta, symbol, position, true)
        {
            
        }

        public override void Interact(Player player)
        {
            //전투를 시작한다.
        }

        public abstract void Attack();

    }
}
