using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.GameObjects
{
    class Trap : GameObject
    {
        public string name;
        public string description;

        public Trap(Vector2 position)
            : base(ConsoleColor.Red, 'F', position, false)
        {
            name = "함정";
            description = "플레이어가 데미지를 입는다.";
        }

        public override void Interact(Player player)
        {
            Game.Player.curHP -= 10;
            if(Game.Player.curHP <= 0 )
            {
                Game.reason = "함정을 밟아 죽었습니다.";
                Game.gameOver = true;
            }
        }
    }
}
