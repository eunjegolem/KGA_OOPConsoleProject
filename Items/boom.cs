﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Items
{
    public class Boom : Item
    {
        public Boom(Vector2 position)
            : base('B', position, 2)
        {
            name = "폭탄";
            description = "적을 공격하는 아이템";
            
        }

        public override void Use()
        {
            Game.Player.Attack(80);
        }
    }
}
