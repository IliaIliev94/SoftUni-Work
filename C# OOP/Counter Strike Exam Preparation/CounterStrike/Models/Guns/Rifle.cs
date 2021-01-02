namespace CounterStrike.Models.Guns
{
    public class Rifle : Gun
    {
        private const int FireRate = 10;
        public Rifle(string name, int bulletsCount) : base(name, bulletsCount)
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