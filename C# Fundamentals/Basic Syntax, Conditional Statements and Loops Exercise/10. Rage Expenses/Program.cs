using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrash = lostGames / 2;
            int mouseTrash = lostGames / 3;
            int keyboardTrash = mouseTrash / 2;
            int displayTrash = keyboardTrash / 2;

            double expenses = headsetPrice * headsetTrash + mouseTrash * mousePrice + keyboardTrash * keyboardPrice + displayPrice * displayTrash;
            Console.WriteLine($"Rage expenses: {expenses.ToString("0.00")} lv.");
        }
    }
}
