using System.Collections.Generic;

namespace KGA_OOPConsoleProject.Scenes
{
    class SwampFieldScene : FieldScene
    {
        public SwampFieldScene()
        {
            name = "SwampFieldScene";
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
            gameObjects.Add(new Place("IslandFieldScene", 'I', new Vector2(1, 1)));
            gameObjects.Add(new Place("MountainFieldScene", 'M', new Vector2(18, 9)));
        }
        public override void Enter()
        {
            if (Game.prevSceneName == "IslandFieldScene")
            {
                Game.Player.position = new Vector2(1, 1);
            }
            else if (Game.prevSceneName == "MountainFieldScene")
            {
                Game.Player.position = new Vector2(18, 9);
            }
            Game.Player.map = map;
        }
    }
}
