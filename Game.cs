﻿using KGA_OOPConsoleProject.Scenes;
using KGA_OOPConsoleProject.Scenes.Shops;
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
        public static string reason;
        

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

            End(reason);

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
            //필드 씬
            sceneDic.Add("CampFireFieldScene", new CampFireFieldScene());
            sceneDic.Add("TownScene", new TownScene());
            sceneDic.Add("ForestFieldScene", new ForestFieldScene());
            sceneDic.Add("PlainFieldScene", new PlainFieldScene());
            sceneDic.Add("IslandFieldScene", new IslandFieldScene());
            sceneDic.Add("SwampFieldScene", new SwampFieldScene());
            sceneDic.Add("MountainFieldScene", new MountainFieldScene());
            //상점 씬
            sceneDic.Add("ItemShopScene", new ItemShopScene());
            sceneDic.Add("EquipmentShopScene", new EquipmentShopScene());
            sceneDic.Add("MagicShopScene", new MagicShopScene());
            sceneDic.Add("INNScene", new INNScene());
            sceneDic.Add("Buyitem", new Buyitem());
            sceneDic.Add("Sellitem", new Sellitem());
            sceneDic.Add("Upgradeitem", new Upgradeitem());
            sceneDic.Add("Confirm", new Confirm());


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
