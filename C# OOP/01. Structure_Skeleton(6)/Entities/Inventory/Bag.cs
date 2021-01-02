using System;
using System.Collections.Generic;
using System.Linq;
using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private List<Item> items;
        public int Capacity { get; set; } = 100;

        public int Load
        {
            get { return items.Sum(item => item.Weight); }
        }

        public IReadOnlyCollection<Item> Items
        {
            get
            {
                return this.items.AsReadOnly();
            }
        }
        public void AddItem(Item item)
        {
            if (Load + item.Weight > Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.ExceedMaximumBagCapacity);
            }
            items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (items.Count <= 0)
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyBag);
            }
            Item returnedItem = items.FirstOrDefault(item => item.GetType().Name.Equals(name));

            if (returnedItem == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.ItemNotFoundInBag, name));
            }

            this.items.Remove(returnedItem);
            return returnedItem;
        }

        public Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }
    }
}