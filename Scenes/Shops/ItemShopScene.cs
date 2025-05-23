﻿using System;

namespace KGA_OOPConsoleProject.Scenes
{
    class ItemShopScene : Scene
    {
        string input;

        public ItemShopScene()
        {
            name = "ItemShopScene";
        }
        public override void Render()
        {
            if(Game.prevSceneName != "Buyitem" || Game.prevSceneName != "Sellitem")
            {
                Console.WriteLine("\"어서 오세요. 좋은 물건들이 많이 있다구요~\"");
                Console.WriteLine();
                Console.WriteLine("물건들이 많이 보인다.");
            }            
            Console.WriteLine("어떤 거래를 하시겠습니까?");
        }

        public override void Choice()
        {
            Console.WriteLine("1. 산다  2. 판다 3. 나간다");
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
                    //buy item
                    Game.ChangeScene("Buyitem");
                    return;
                case "2":
                    //sell item
                    Game.ChangeScene("Sellitem");
                    return;
                case "3":
                    Game.ChangeScene("TownScene");
                    return;
            }
        }
    }
}
