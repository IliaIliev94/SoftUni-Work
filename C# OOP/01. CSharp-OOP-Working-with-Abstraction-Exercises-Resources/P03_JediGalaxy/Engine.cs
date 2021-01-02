using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_JediGalaxy
{
    public class Engine
    {
        private Galaxy galaxy;
        private Player player;
        private Evil evil;

        public Engine()
        {

        }

        public void Run()
        {

            string command = Console.ReadLine();
            while (!command.Equals("Let the Force be with you"))
            {
                int[] dimestions = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                galaxy = new Galaxy(dimestions[0], dimestions[1]);
                this.Initialize();
                int[] ivoS = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                player = new Player(ivoS[0] - 1, ivoS[1] - 1);
                int[] evilInfo = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                evil = new Evil(evilInfo[0] - 1, evilInfo[1] - 1);

                for (int i = 0; this.evil.X >= 0 && this.evil.Y >= 0; i++)
                {
                    this.galaxy[this.evil.X, this.evil.Y] = 0;
                    this.evil.Move();
                }

                for (int i = 0; this.player.X >= 0 && this.player.Y <= this.galaxy.Width; i++)
                {
                    this.player.Sum += this.galaxy[this.player.X, this.player.Y];
                    this.player.Move();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(player.Sum);
        }

        public void Initialize()
        {
            int value = 0;
            for(int i = 0; i < this.galaxy.Length; i++)
            {
                for(int j = 0; j < this.galaxy.Width; j++)
                {
                    this.galaxy[i, j] = value;
                    value++;
                }
            }
        }
    }
}
