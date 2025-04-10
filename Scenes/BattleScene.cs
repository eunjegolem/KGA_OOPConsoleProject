using KGA_OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    class BattleScene : Scene
    {
        string input;
        public override void Render()
        {
            //각종 몬스터와 장소에 따라서 명칭이 변경됨
            Console.WriteLine("몬스터가 나타났다.");
        }
        public override void Choice()
        {
            Console.WriteLine("1. 공격 2. 도주");
        }
        public override void Input()
        {
            while (true)
            {
                //플레이어공격
                switch (input)
                {
                    case "1":

                        return;
                    case "2":
                        //확율로 도주할지 결정
                        //실패하면 break;
                        return;                        
                    default:
                        break;
                }
                //몬스터 공격
                Console.WriteLine("몬스터가 공격했다.");
                //플레이어의 데미지 계산
                Console.ReadKey();
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
            //만일 도주에 성공하면 돌아가는 맵에 몬스터는 사라지지 않도록 구현
            Game.ChangeScene(Game.prevSceneName);
        }
    }
}
