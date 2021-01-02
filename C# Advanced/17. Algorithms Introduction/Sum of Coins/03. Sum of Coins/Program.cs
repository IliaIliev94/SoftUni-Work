using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Sum_of_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableCoins = Console.ReadLine().Split(':')[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var targetSum = int.Parse(Console.ReadLine().Split(':')[1].Trim());
            var temp = targetSum;
            var selectedCoins = ChooseCoins(availableCoins, ref targetSum);

            if (selectedCoins != null)
            {
                Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
                foreach (var selectedCoin in selectedCoins)
                {
                    Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static Dictionary<int, int> ChooseCoins(IList<int> coins, ref int targetSum)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            int coinSum = 0;
            int coinIndex = 0;
            coins = coins.OrderByDescending(x => x).ToArray();
            while(coinIndex < coins.Count && coinSum < targetSum)
            {
                int currentSum = targetSum - coinSum;
                int currentCoin = coins[coinIndex];
                int amount = currentSum / currentCoin;
                if (amount > 0)
                {
                    result.Add(currentCoin, amount);
                    coinSum += amount * currentCoin;
                }
                coinIndex++;
            }

            if (coinSum != targetSum)
            {
                return null;
            }

            return result;
        }
    }

}
