using System;
using System.Linq;
using System.Text;
using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private GunRepository guns = new GunRepository();
        private PlayerRepository players = new PlayerRepository();
        private Map map = new Map();
        public string AddGun(string type, string name, int bulletsCount)
        {
            if (!type.Equals("Pistol") && !type.Equals("Rifle"))
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }

            IGun gun = CreateGun(type, name, bulletsCount);
            guns.Add(gun);
            return String.Format(OutputMessages.SuccessfullyAddedGun, name);
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            if (guns.FindByName(gunName) == null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }

            else if (!type.Equals("Terrorist") && !type.Equals("CounterTerrorist"))
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }

            IPlayer player = CreatePlayer(type, username, health, armor, gunName);
            players.Add(player);
            return String.Format(OutputMessages.SuccessfullyAddedPlayer, username);
        }

        public string StartGame()
        {
            return map.Start(players.models);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            players.models = players.models.OrderBy(player => player.GetType().Name)
                .ThenByDescending(player => player.Health).ThenBy(player => player.Username).ToList();
            for (var i = 0; i < players.Models.Count; i++)
            {
                result.AppendLine(players.models[i].ToString());
            }
            return result.ToString().TrimEnd();
        }

        private IGun CreateGun(string type, string name, int bulletsCount)
        {
            IGun gun = null;
            switch (type)
            {
                case "Pistol":
                    gun = new Pistol(name, bulletsCount);
                    break;
                default:
                    gun = new Rifle(name, bulletsCount);
                    break;
            }

            return gun;
        }

        private IPlayer CreatePlayer(string type, string username,int health, int armor, string gunName)
        {
            IPlayer player = null;
            IGun gun = guns.FindByName(gunName);
            switch (type)
            {
                case "Terrorist":
                    player = new Terrorist(username, health, armor, gun);
                    break;
                default:
                    player = new CounterTerrorist(username, health, armor, gun);
                    break;
            }

            return player;
        }
    }
}