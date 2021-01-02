using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Christmas
{
    class Bag
    {

        public List<Present> Data { get; set; }

        public string Color { get; set; }

        public int Capacity { get; set; }

        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            this.Data = new List<Present>();
        }

        public void Add(Present present)
        {
            if(this.Data.Count < this.Capacity)
            {
                this.Data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            foreach(var present in this.Data)
            {
                if(present.Name == name)
                {
                    this.Data.Remove(present);
                    return true;
                }
            }
            return false;
        }

        public Present GetHeaviestPresent()
        {
            Present result = this.Data[0];
            for(int i = 1; i < this.Data.Count; i++)
            {
                if(this.Data[i].Weight > result.Weight)
                {
                    result = this.Data[i];
                }
            }
            return result;
        }

        public Present GetPresent(string name)
        {
            Present result = new Present("", 0, "");
            foreach(var present in this.Data)
            {
                if(present.Name == name)
                {
                    result =  present;
                }
            }
            return result;
        }

        public int Count
        {
            get
            {
                return this.Data.Count;
            }
        }

        public void Report()
        {
            Console.WriteLine($"{this.Color} bag contains:");
            foreach(var present in this.Data)
            {
                Console.WriteLine(present.ToString());
            }
        }
    }
}
