using KGA_OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public static class Game
    {
        //씬 사전에 선언
        private static Dictionary<string, Scene> sceneDic;
        //현재 씬 선언
        private static Scene curScene;
        //이전 씬 이름 선언
        public static string prevSceneName;

        //플레이어를 외부에서 변경못하게 선언
        private static Player player;
        //플레이어 외부에서 읽기만하기
        public static Player Player {  get { return player; } }

        public static bool gameOver;

        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Result();
                curScene.Wait();
                curScene.ChangeScene();
            }

            End("게임 종료를 선택하셨습니다.");

        }
        public static void ChangeScene(string sceneName)
        {
            prevSceneName = curScene.name;

            curScene.Exit();
            curScene = sceneDic[sceneName];
            curScene.Enter();
        }
        private static void Start()
        {
            Console.CursorVisible = false;

            // 게임 설정
            gameOver = false;

            // 플레이어 설정
            player = new Player();

            // 씬 설정
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new Title());
            sceneDic.Add("CampFireFieldScene", new CampFireFieldScene());
            sceneDic.Add("TownScene", new TownScene());
            sceneDic.Add("ForestFieldScene", new ForestFieldScene());
            sceneDic.Add("PlainFieldScene", new PlainFieldScene());
            sceneDic.Add("IslandFieldScene", new IslandFieldScene());
            sceneDic.Add("SwampFieldScene", new SwampFieldScene());
            sceneDic.Add("MountainFieldScene", new MountainFieldScene());

            curScene = sceneDic["Title"];
        }
        private static void End(string reason)
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("*          Game Over!!           *");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine(reason);

            gameOver = true;
        }
    }
}
