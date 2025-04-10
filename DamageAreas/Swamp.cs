using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    class Swamp : DamegeArea
    {
        public Swamp(Vector2 position) : base('S', position, false)
        {
            name = "늪";
            description = "플레이어가 독 데미지를 입는다.";
        }

        public override void Interact(Player player)
        {
            Game.Player.curHP -= 10;
            if (Game.Player.curHP <= 0)
            {
                Game.reason = "늪에 빠져 죽었습니다.";
                Game.gameOver = true;
            }
        }
    }
}
