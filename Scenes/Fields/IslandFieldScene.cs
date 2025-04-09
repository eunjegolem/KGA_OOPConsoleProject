using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    class IslandFieldScene : FieldScene
    {
        public IslandFieldScene()
        {
            name = "IslandFieldScene";
            fieldname = "Island";
            mapData = new string[]
            {
              //      01234567890123456789
              /*0*/  "####################",
              /*1*/  "#                  #",
              /*2*/  "#                  #",
              /*3*/  "#                  #",
              /*4*/  "#                  #",
              /*5*/  "#                  #",
              /*6*/  "#                  #",
              /*7*/  "#                  #",
              /*8*/  "#                  #",
              /*9*/  "#                  #",
              /*0*/  "#                  #",
              /*1*/  "#                  #",
              /*2*/  "#                  #",
              /*3*/  "#                  #",
              /*4*/  "#                  #",
              /*5*/  "#                  #",
              /*6*/  "#                  #",
              /*7*/  "#                  #",
              /*8*/  "#                  #",
              /*9*/  "####################"
            };

            map = new bool[20, 20];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] != '#';
                }
            }

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("PlainFieldScene", 'P', new Vector2(1, 9)));
            gameObjects.Add(new Place("SwampFieldScene", 'S', new Vector2(18, 18)));
        }
        public override void Enter()
        {
            if (Game.prevSceneName == "SwampFieldScene")
            {
                Game.Player.position = new Vector2(18, 18);
            }
            else if (Game.prevSceneName == "PlainFieldScene")
            {
                Game.Player.position = new Vector2(1, 9);
            }
            Game.Player.map = map;
        }
    }
        
    
}
