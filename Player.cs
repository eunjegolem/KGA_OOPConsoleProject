using KGA_OOPConsoleProject.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Player
    {
        public Vector2 position;
        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }
        public bool[,] map;

        public int curHP;
        public int CurHP { get { return curHP; } }
        public int curMP;
        public int CurMp { get { return curMP; } }
        public int maxHP;
        public int MaxHP { get { return maxHP; } }
        public int maxMP;
        public int MaxMP { get { return maxMP; } }
        public int gold;

        public int str;
        
        
        //플레이어정의
        public Player()
        {
            inventory = new Inventory();
            maxHP = 100;
            curHP = maxHP;
            gold = 0;
            str = 10;
        }
        //회복
        public void Heal(int amount)
        {
            curHP += amount;
            if (curHP > maxHP)
            {
                curHP = maxHP;
            }
        }
        //플레이어 맵에 그리기
        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }
        //플레이어 공격하기
        public void Attack(int amount)
        {
            
        }

        public void Move(ConsoleKey input)
        {
            Vector2 targetPos = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    targetPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    targetPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    targetPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    targetPos.x++;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }


        public void ShowStatus(string name, string job)
        {
            Console.WriteLine($"플레이어 정보");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"직업: {job}");
            //Console.WriteLine($"레벨: {level}");
            //Console.WriteLine($"HP: {curHp}");
            //Console.WriteLine($"MP: {curMp}");
            Console.WriteLine($"힘: {str}");
            //Console.WriteLine($"민첩: {agi}");
            //Console.WriteLine($"생명: {vit}");
            //Console.WriteLine($"손재주: {dex}");
            //Console.WriteLine($"지능: {intel}");
            //Console.WriteLine($"행운: {luk}");
            //Console.WriteLine($"매력: {cham}");


        }
    }
}
