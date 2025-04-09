using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes.Shops
{
    class Confirm : Scene
    {
        string input;
        public Confirm()
        {
            name = "Confirm";
        }
        public override void Render()
        {
            //사거나 팔거나 업그레이드 할 아이템을 가지고 옴

            if (Game.prevSceneName == "Buyitem")
            {
                Console.WriteLine("{0}을 구매", Buyitem.targetitem);
            }
            else if (Game.prevSceneName == "Sellitem")
            {
                Console.WriteLine("{0}을 판매", Sellitem.targetitem);
            }
            else
            {
                Console.WriteLine("{0}을 강화", Upgradeitem.targetitem);
            }
            Console.WriteLine("하시겠습니까?");
        }

        public override void Choice()
        {
            if (Game.prevSceneName == "Buyitem")
            {
                Console.Write("1. 구매");
            }
            else if (Game.prevSceneName == "Sellitem")
            {
                Console.Write("1. 판매");
            }
            else
            {
                Console.Write("1. 강화");
            }
            Console.WriteLine("한다.  2. 그만둔다");
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
                        //구매시
                        if (Game.prevSceneName == "Buyitem")
                        {
                            //인벤토리에 구매할 아이템을 추가한다.
                            
                            return;
                        }
                        //판매시
                        else if (Game.prevSceneName == "Sellitem")
                        {
                            //인벤토리에 판매할 아이템을 제거한다.
                            return;
                        }
                        //강화시
                        else
                        {
                            //인벤토리에 강화할 아이템을 제거한 후 강화된 추가한다. 혹은 아이템의 수치를 변경한다.
                            return;
                        }


                    case "2":
                        Console.WriteLine();
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
            Game.ChangeScene(Game.prevSceneName);
        }
    }
}
