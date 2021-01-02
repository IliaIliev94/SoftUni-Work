using System;
using System.Collections.Generic;
using System.Text;
using _03._Raiding.Models;
using _03._Raiding.HeroFactory;

namespace _03._Raiding.Core
{
    public class Engine : IEngine
    {
        private IHeroFactory heroFactory;
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int totalPower = 0;
            heroFactory = new HeroFactory.HeroFactory();
            List<IBaseHero> heroes = new List<IBaseHero>();
            int i = 0;
            while(i < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                IBaseHero hero = heroFactory.CreateHero(type, name);
                if(hero == null)
                {
                    Console.WriteLine("Invalid hero!");
                }
                else
                {
                    heroes.Add(hero);
                    i++;
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            foreach(var hero in heroes)
            {
                totalPower += hero.Power;
                Console.WriteLine(hero.CastAbility());
            }

            if(totalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
