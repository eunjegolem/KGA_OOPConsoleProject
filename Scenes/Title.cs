using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KGA_OOPConsoleProject.Scenes
{
    class Title : Scene
    {
        string input;
        public Title() 
        {
            name = "Title";
        }
        public override void Render()
        {
            Console.WriteLine("===== 텍스트 RPG =====");
        }
        public override void Choice()
        {
            Console.WriteLine("1. 모험 시작");
            Console.WriteLine("2. 게임 종료");
            Console.Write("선택: ");
        }
        public override void Input()
        {
            while (true)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("게임을 시작합니다.");
                        return;
                    case "2":
                        Console.WriteLine("게임을 종료합니다.");
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
                    Game.ChangeScene("CampFireFieldScene");
                    return;
                case "2":
                    Game.gameOver = true;
                    return;
            }
            
        }
    }
}
