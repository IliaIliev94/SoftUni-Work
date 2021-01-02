using System;

namespace _03._Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 500));
            Console.WriteLine(product);
        }
        public static void Execute(Product product, ModifyPrice modifyPrice, ICommand command)
        {
            modifyPrice.SetCommand(command);
            modifyPrice.Invoke();
        }
    }
}
