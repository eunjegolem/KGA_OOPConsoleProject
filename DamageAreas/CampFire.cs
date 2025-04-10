using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    class CampFire : DamegeArea
    {
        public CampFire(Vector2 position) : base('F', position, true)
        {
            name = "모닥불";
            description = "플레이어가 불 데미지를 입는다.";
        }

        public override void Interact(Player player)
        {
            Game.Player.curHP -= 10;
            if (Game.Player.curHP <= 0)
            {
                Game.reason = "불을 밟아 죽었습니다.";
                Game.gameOver = true;
            }
        }
    }
}
