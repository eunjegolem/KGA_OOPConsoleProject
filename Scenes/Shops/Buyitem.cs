using KGA_OOPConsoleProject.Equipments;
using KGA_OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes.Shops
{
    class Buyitem : Scene
    {
        string input;
        

        Potion Potion = new Potion(new Vector2(0, 0));
        Boom Boom = new Boom(new Vector2(0, 0));
        IronSword IronSword = new IronSword(new Vector2(0, 0));

        public Buyitem()
        {
            name = "Buyitem";
        }
        public override void Render()
        {
            Console.WriteLine("\"그럼 골라 보세요~\"");
            Console.WriteLine();
            Console.WriteLine("어떤 물건을 살까?");
        }

        public override void Choice()
        {
            Console.Write("1. 포션 ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("1 Gold");
            Console.ResetColor();
            Console.Write(" 2. 폭탄 ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("2 Gold");
            Console.ResetColor();
            Console.Write(" 3. 철검 ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("3 Gold");
            Console.ResetColor();
            Console.WriteLine(" 4. 그만둔다");
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
                        //구매할 아이템의 가격을 플레이어의 소지금과 비교한다.
                        if(Game.Player.gold > Potion.price)
                        {
                            //소지금을 차감하고 아이템을 리스트에 추가함
                            Game.Player.gold -= Potion.price;
                            //추가 기능 미구현
                            //Inventory.Add();

                            //컴펌클래스로 이관 : 하려 했으나 설계 변경을 요함
                            //targetitem = Potion.name;

                            break;
                        }
                        else
                        {
                            Console.WriteLine("소지금이 부족합니다.");
                            break;
                        }

                        
                    case "2":
                        if (Game.Player.gold > Boom.price)
                        {
                            //소지금을 차감하고 아이템을 리스트에 추가함
                            Game.Player.gold -= Potion.price;
                            
                            //컴펌클래스로 이관 : 하려 했으나 설계 변경을 요함
                            //targetitem = Boom.name;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("소지금이 부족합니다.");
                            break;
                        }

                        return;
                    case "3":
                        if (Game.Player.gold > IronSword.price)
                        {
                            //소지금을 차감하고 아이템을 리스트에 추가함
                            Game.Player.gold -= Potion.price;
                            
                            //컴펌클래스로 이관 : 하려 했으나 설계 변경을 요함
                            //targetitem = IronSword.name;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("소지금이 부족합니다.");
                            break;
                        }
                        return;
                    case "4":
                        Console.WriteLine("다른 거래를 알아본다.");
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
                    
                    return;
                case "2":
                    
                    return;
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
                    //Game.ChangeScene("Confirm");
                    //return;
                case "4":
                    Game.ChangeScene("ItemShopScene");
                    return;
            }
        }
    }
}
