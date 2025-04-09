using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes.Shops
{
    class Sellitem : Scene
    {
        string input;
        string targetitem;
        

        public Sellitem()
        {
            name = "Sellitem";
        }
        public override void Render()
        {
            //만일 인벤토리에 아이템이 없으면
            Console.WriteLine("팔 물건이 없습니다.");
            //인벤토리에 아이템이 있으면
            Console.WriteLine("\"어떤 물건을 파시겠습니까?\"");
            
        }

        public override void Choice()
        {
            //인벤토리에 가지고 있는 아이템을 배열에 넣고 금액을 표시한다.
            Game.Player.Inventory.PrintALL();
        }

        public override void Input()
        {
            //항목의 숫자를 입력한다.
        }
        public override void Update()
        {

        }


        public override void Result()
        {
            switch (input)
            {
                case "3":
                    Console.WriteLine("상점을 나갑니다.");
                    return;
            }
        }



        public override void Wait()
        {

        }
        public override void ChangeScene()
        {
            switch (input)
            {
                case "1":
                case "2":
                    Game.ChangeScene("Confirm");
                    return;
                case "3":
                    Game.ChangeScene("TownScene");
                    return;
            }
        }
    }
}
