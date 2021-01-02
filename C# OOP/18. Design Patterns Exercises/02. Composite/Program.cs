using System;

namespace _02._Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            GiftBase phone = new SingleGift("Phone", 256);

            CompositeGift rootBox = new CompositeGift("RootBox", 10);
            SingleGift truckToy = new SingleGift("TruckToy", 289);
            SingleGift plainToy = new SingleGift("PlainToy", 587);
            rootBox.Add(truckToy);
            rootBox.Add(plainToy);

            CompositeGift childBox = new CompositeGift("ChildBox", 5);
            GiftBase soldierToy = new SingleGift("SoldierToy", 200);
            childBox.Add(soldierToy);
            rootBox.Add(childBox);
            Console.WriteLine(rootBox);
        }
    }
}
