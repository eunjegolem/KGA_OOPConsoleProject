using KGA_OOPConsoleProject.Equipments;
using KGA_OOPConsoleProject.GameObjects;
using KGA_OOPConsoleProject.Items;
using KGA_OOPConsoleProject.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    
    class CampFireFieldScene : FieldScene
    {
        //char[,] map;
        public CampFireFieldScene()
        {
            name = "CampFireFieldScene";
            mapData = new string[]
            {
              //      012345678
              /*0*/  "########",
              /*1*/  "#      #",
              /*2*/  "#      #",
              /*3*/  "#      #",
              /*4*/  "#      #",
              /*5*/  "#      #",
              /*6*/  "#      #",
              /*7*/  "########"
            };

            map = new bool[8, 8];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                
                for (int x = 0; x < map.GetLength(1); x++)
                {   
                    map[y, x] = mapData[y][x] != '#';
                }
            }

            gameObjects = new List<GameObject>();
            for(int i= 1;i < map.GetLength(0)-1;i++)
            {
                for(int j = 1;j < map.GetLength(1)-1;j++)
                {
                    if (i == 1 || i == 6 || j == 1 || j == 6)
                    {
                        gameObjects.Add(new Place("ForestFieldScene", 'F', new Vector2(i, j)));
                    }
                    
                }
                
            }
            gameObjects.Add(new Potion(new Vector2(3, 4)));
            gameObjects.Add(new Boom(new Vector2(3, 3)));
            gameObjects.Add(new Gold(new Vector2(5, 4)));
            gameObjects.Add(new Trap(new Vector2(4, 4)));
            gameObjects.Add(new IronSword(new Vector2(5, 5)));
        }
        public override void Enter()
        {
            if (Game.prevSceneName == "Title")
            {
                Game.Player.position = new Vector2(4, 5);
            }
            else if (Game.prevSceneName == "ForestFieldScene")
            {
                Game.Player.position = new Vector2(4, 5);
            }
            Game.Player.map = map;
        }

    }
}
