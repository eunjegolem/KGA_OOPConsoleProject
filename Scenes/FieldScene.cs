using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public abstract class FieldScene : Scene
    {
        private ConsoleKey input;

        protected string[] mapData;
        protected bool[,] map;

        protected List<GameObject> gameObjects;

        public override void Render()
        {
            //맵 그리기
            PrintMap();
            foreach (GameObject go in gameObjects)
            {
                go.Print();
            }
            //플레이어 그리기
            Game.Player.Print();

            Console.SetCursorPosition(0, map.GetLength(0) + 1);
            Console.WriteLine("HP {0}/{1}, MP {2}/{3} ", Game.Player.curHP, Game.Player.MaxHP, Game.Player.curMP, Game.Player.MaxMP);
            //인벤토리 그리기
            Game.Player.Inventory.PrintALL();
        }
        public override void Choice()
        {

        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            Game.Player.Move(input);
        }

        public override void Result()
        {
            
        }
        public override void Wait()
        {
            
        }
        public override void ChangeScene()
        {
            foreach (GameObject go in gameObjects)
            {
                if (Game.Player.position == go.position)
                {
                    go.Interact(Game.Player);
                    if (go.isOnce == true)
                    {
                        gameObjects.Remove(go);
                    }
                    break;
                }
            }
        }

        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
