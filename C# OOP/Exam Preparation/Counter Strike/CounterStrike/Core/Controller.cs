using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CounterStrike.Models.Players;
using CounterStrike.Models.Maps;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private GunRepository guns;
        private PlayerRepository players;
        private IMap map;
        private List<IPlayer> totalPlayers;
        public string AddGun(string type, string name, int bulletsCount)
        {
            IGun gun = null;
            switch(type)
            {
                case "Pistol":
                    gun = new Pistol(name, bulletsCount);
                    break;
                case "Rifle":
                    gun = new Rifle(name, bulletsCount);
                    break;
            }
            if(gun == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }
            this.guns.Add(gun);
            return string.Format(OutputMessages.SuccessfullyAddedGun, name);
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            IGun gun = guns.FindByName(gunName);
            if(gun == null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }
            IPlayer player = null;

            switch(type)
            {
                case "Terrorist":
                    player = new Terrorist(username, health, armor, gun);
                    break;
                case "CounterTerrorist":
                    player = new CounterTerrorist(username, health, armor, gun);
                    break;
            }
            if(player == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }
            this.players.Add(player);
            this.totalPlayers.Add(player);
            return string.Format(OutputMessages.SuccessfullyAddedPlayer, username);
        }

        public string Report()
        {
            List<IPlayer> printPlayers = totalPlayers.OrderBy(player => player.GetType().Name).ThenByDescending(player => player.Health).ThenBy(player => player.Username).ToList();
            StringBuilder result = new StringBuilder();
            for(int i = 0; i < printPlayers.Count; i++)
            {
                if(i != printPlayers.Count - 1)
                {
                    result.AppendLine(printPlayers[i].ToString());
                }
                else
                {
                    result.Append(printPlayers[i].ToString());
                }
            }
            return result.ToString();
        }

        public string StartGame()
        {
            return map.Start(totalPlayers);
        }

        public Controller()
        {
            this.guns = new GunRepository();
            this.players = new PlayerRepository();
            this.map = new Map();
            this.totalPlayers = new List<IPlayer>();
        }
    }
}
