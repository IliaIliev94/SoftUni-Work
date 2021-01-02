using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.TestClasses
{
    public class FakeDummy : ITarget
    {
        private int experience => 20;
        public int Health => 0;


        public int GiveExperience()
        {
            return experience;
        }

        public bool IsDead()
        {
            return true;
        }

        public void TakeAttack(int attackPoints)
        {

        }
    }
}
