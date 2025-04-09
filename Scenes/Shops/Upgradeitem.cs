using System;
using System.Collections.Generic;

namespace KGA_OOPConsoleProject.Scenes.Shops
{
    class Upgradeitem : Scene
    {
        string input;
        string targetitem;
        

        public Upgradeitem()
        {
            name = "Upgradeitem";
        }
        public override void Render()
        {
            Console.WriteLine("\"캉캉캉!!\"");
            Console.WriteLine();
            Console.WriteLine("대장장이는 흠씬 망치질에 여념이 없다.");
            Console.WriteLine("어떤 거래를 하시겠습니까?");
        }

        public override void Choice()
        {
            Console.WriteLine("1. 산다  2. 판다 3. 강화한다 4. 나간다");
            Console.WriteLine();
            Game.Player.Inventory.PrintALL();
        }

        public override void Input()
        {
            while (true)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //상점의 아이템과 판매 가격 내 골드를 보여줌

                        return;
                    case "2":
                        //보유 아이템과 판매 가격과 내 골드를 보여줌

                        return;
                    case "3":
                        //강화가 가능한 보유 아이템(장비)를 강화한다.
                        return;
                    case "4":
                        Console.WriteLine("상점을 나갑니다.");
                        return;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }
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
                case "3":
                    Game.ChangeScene("Confirm");
                    return;
                case "4":
                    Game.ChangeScene("TownScene");
                    return;
            }
        }
    }
}
