using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    class TownScene : FieldScene
    {
        public TownScene()
        {
            name = "TownScene";
            mapData = new string[]
            {
              //      01234567890123456789
              /*0*/  "####################",
              /*1*/  "#                  #",
              /*2*/  "#                  #",
              /*3*/  "#  ###        ###  #",
              /*4*/  "#  # #        # #  #",
              /*5*/  "#  # #        # #  #",
              /*6*/  "#                  #",
              /*7*/  "#     ########     #",
              /*8*/  "#     #      #     #",
              /*9*/  "#     # #### #     #",
              /*0*/  "#     # #  # #     #",
              /*1*/  "#     # #  # #     #",
              /*2*/  "#     #      #     #",
              /*3*/  "#                  #",
              /*4*/  "#  ###        ###  #",
              /*5*/  "#  # #        # #  #",
              /*6*/  "#  # #        # #  #",
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
            gameObjects.Add(new Place("PlainFieldScene", 'G', new Vector2(10, 18)));
            gameObjects.Add(new Place("PlainFieldScene", 'G', new Vector2(10, 1)));
            gameObjects.Add(new Place("PlainFieldScene", 'G', new Vector2(1, 10)));
            gameObjects.Add(new Place("PlainFieldScene", 'G', new Vector2(18, 10)));
            gameObjects.Add(new Place("ItemShopScene", 'I', new Vector2(4, 15)));
            gameObjects.Add(new Place("EquipmentShopScene", 'E', new Vector2(15, 15)));
            gameObjects.Add(new Place("MagicShopScene", 'M', new Vector2(4, 4)));
            gameObjects.Add(new Place("INNScene", 'N', new Vector2(15, 4)));
        }
        public override void Enter()
        {
            if (Game.prevSceneName == "PlainFieldScene")
            {
                Game.Player.position = new Vector2(10, 18);
            }
            else if (Game.prevSceneName == "ItemShopScene")
            {
                Game.Player.position = new Vector2(4, 15);
            }
            else if (Game.prevSceneName == "EquipmentShopScene")
            {
                Game.Player.position = new Vector2(15, 15);
            }
            else if (Game.prevSceneName == "MagicShopScene")
            {
                Game.Player.position = new Vector2(4, 4);
            }
            else if (Game.prevSceneName == "INNScene")
            {
                Game.Player.position = new Vector2(15, 4);
            }
            Game.Player.map = map;
        }
    }
}
