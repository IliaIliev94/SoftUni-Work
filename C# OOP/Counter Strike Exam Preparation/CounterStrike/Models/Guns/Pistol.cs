namespace CounterStrike.Models.Guns
{
    public class Pistol : Gun
    {
        private const int FireRate = 1;
        public Pistol(string name, int bulletsCount) : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (this.BulletsCount >= 1)
            {
                this.BulletsCount -= 1;
                return 1;
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