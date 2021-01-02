using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Models.Maps
{
    class Map : IMap
    {
        public string Start(ICollection<IPlayer> players)
        {
            List<IPlayer> terrorists = players.Where(player => player.GetType().Name == "Terrorist").ToList();
            List<IPlayer> counterTerrorists = players.Where(player => player.GetType().Name == "CounterTerrorist").ToList();

            while(true)
            {
                foreach(var terrorist in terrorists)
                {
                    foreach(var counterTerrorist in counterTerrorists)
                    {
                        counterTerrorist.TakeDamage(terrorist.Gun.Fire());
                    }
                }
                foreach(var counterTerorist in counterTerrorists)
                {
                    foreach(var terrorist in terrorists)
                    {
                        terrorist.TakeDamage(counterTerorist.Gun.Fire());
                    }
                }
                if (counterTerrorists.All(counterTerrorist => !counterTerrorist.IsAlive))
                {
                    return "Terrorist wins!";
                }
                else if (terrorists.All(terrorist => !terrorist.IsAlive))
                {
                    return "Counter Terrorist wins!";
                }
            }

        }
    }
}
