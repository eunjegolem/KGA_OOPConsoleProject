using System;

namespace KGA_OOPConsoleProject.Scenes
{
    class INNScene : Scene
    {
        string input;
        public INNScene()
        {
            name = "INNScene";
        }
        public override void Render()
        {
            Console.WriteLine("\"어서 오세요. 오래 기다렸다구요~\"");
            Console.WriteLine();
            Console.WriteLine("\"여관 잠의 소환에 오신 것을 환영합니다.\"");
            Console.WriteLine("자고 가시겠습니까?");
        }

        public override void Choice()
        {
            Console.WriteLine("1. 잔다  2. 나간다");
        }

        public override void Input()
        {
            while (true)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("방의 열쇠를 받았습니다.");
                        return;
                    case "2":
                        Console.WriteLine("여관을 나갑니다.1");
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
                case "1":
                    Console.WriteLine("체력이 모두 회복되었습니다.");
                    return;
                case "2":
                    Console.WriteLine("여관을 나갑니다.2");
                    return;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
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
