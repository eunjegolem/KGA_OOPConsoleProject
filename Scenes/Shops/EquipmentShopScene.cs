using System;

namespace KGA_OOPConsoleProject.Scenes
{
    class EquipmentShopScene : Scene
    {
        string input;
        public EquipmentShopScene()
        {
            name = "EquipmentShopScene";
        }
        public override void Render()
        {
            Console.WriteLine("\"어이쿠 손이 미끄러졌네! 어서오세요~\"");
            Console.WriteLine();
            Console.WriteLine("장비들이 많이 보인다.");
            Console.WriteLine("어떤 거래를 하시겠습니까?");
        }

        public override void Choice()
        {
            Console.WriteLine("1. 산다  2. 판다 3. 강화한다. 4. 나간다");
        }

        public override void Input()
        {
            while (true)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("상점의 장비를 삽니다.");
                        return;
                    case "2":
                        Console.WriteLine("보유한 장비를 팝니다.");
                        return;
                    case "3":
                        Console.WriteLine("보유한 장비를 강화합니다.");
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

        }



        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 눌러주세요...");
            Console.ReadKey();
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
