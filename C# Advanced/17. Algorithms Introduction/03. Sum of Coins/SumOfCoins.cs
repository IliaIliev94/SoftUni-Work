using System;
using System.Collections.Generic;
using System.Linq;


public class SumOfCoins
{

    public static void Main(string[] args)
    {

        var availableCoins = Console.ReadLine().Split(':')[1].Split(new[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
        var targetSum = int.Parse(Console.ReadLine().Split(':')[1]);
        var selectedCoins = ChooseCoins(availableCoins, targetSum);


        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }



    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {

        Dictionary<int, int> result = new Dictionary<int, int>();
        int coinSum = 0;
        int coinIndex = 0;
        coins = coins.OrderByDescending(x => x).ToList();
        while (coinIndex < coins.Count && coinSum < targetSum)
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
            throw new InvalidOperationException("Error");
        }

        return result;
    }

}