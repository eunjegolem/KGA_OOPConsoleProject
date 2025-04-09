using System;

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
            Console.WriteLine("\"어서 오세요. 좋은 물건들이 많이 있다구요~\"");
            Console.WriteLine();
            Console.WriteLine("물건들이 많이 보인다.");
            Console.WriteLine("어떤 거래를 하시겠습니까?");
        }

        public override void Choice()
        {
            Console.WriteLine("1. 산다  2. 판다 3. 나간다");
        }

        public override void Input()
        {
            while (true)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("상점의 아이템을 삽니다.");
                        return;
                    case "2":
                        Console.WriteLine("보유한 아이템을 팝니다.");
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
                    return;
                case "2":
                    //sell item
                    return;
                case "3":
                    Game.ChangeScene("TownScene");
                    return;
            }
        }
    }
}
