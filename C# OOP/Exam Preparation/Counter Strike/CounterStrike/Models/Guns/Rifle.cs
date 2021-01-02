﻿using CounterStrike.Models.Guns.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public class Rifle : Gun, IGun
    {
        public Rifle(string name, int bulletsCount)
            : base(name, bulletsCount)
        {

        }
        public override int Fire()
        {
            if(this.BulletsCount >= 10)
            {
                this.BulletsCount -= 10;
                return 10;

            }
            else
            {
                int dmg = this.BulletsCount;
                this.BulletsCount = 0;
                return dmg;
            }
        }
    }
}
