using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.TestClasses
{
    public class FakeWeapon : IWeapon
    {
        public int AttackPoints => 20;

        public int DurabilityPoints => 20;

        public void Attack(ITarget target)
        {
            target.TakeAttack(AttackPoints);
        }
    }
}
