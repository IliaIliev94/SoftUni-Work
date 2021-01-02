using System;
using System.Collections.Generic;
using System.Text;

namespace _13._Implementing_Stacks_and_Queues
{
    class List
    {

        private int[] items;

        public int Count { get; private set; }

        private const int InitialCapacity = 2;

        public List()
        {
            this.items = new int[InitialCapacity];
        }

        public int this[int index]
        {
            get
            {
                if(index < 0 || index > this.Count - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return items[index];
                }
            }
            set
            {
                if(index < 0 && index > this.Count - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.items[index] = value;
                }
            }
        }
        public void Add(int element)
        {

            if(this.Count == this.items.Length)
            {
                Resize();

            }
            items[this.Count] = element;
            this.Count++;

        }

        private void Resize()
        {
            int[] temp = new int[items.Length * InitialCapacity];
            for(int i = 0; i < items.Length; i++)
            {
                temp[i] = items[i];
            }
            this.items = temp;
        }

        public int RemoveAt(int position)
        {
            if(position < 0 && position >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            int[] temp = new int[this.Count - 1];
            int num = this.items[position];
            this.items[position] = default(int);
            this.ShiftLeft(position);
            this.Count--;
            if(items.Length / this.Count == 4 )
            {
                this.Shrink();
            }
            return num;
        }


        private void ShiftLeft(int index)
        {
            for(int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }

        }

        private void ShiftRight(int index)
        {
            for(int i = this.Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }

        private void Shrink()
        {
            int[] temp = new int[this.items.Length / InitialCapacity];

            for(int i = 0; i < temp.Length; i++)
            {
                temp[i] = this.items[i];
            }
            this.items = temp;
        }

        public void Insert(int index, int item)
        {
            if(index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("No!");
            }
            if (this.Count <= this.items.Length)
            {
                this.Resize();
            }
            this.ShiftRight(index);
            this.items[index] = item;
            this.Count++;
        }

        public bool Contains(int element)
        {
            bool contains = false;
            for(int i = 0; i < this.Count; i++)
            {
                if(items[i] == element)
                {
                    contains = true;
                }
            }
            return contains;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if ((firstIndex < 0 || firstIndex >= this.Count) || (secondIndex < 0 && secondIndex >= this.Count))
            {
                throw new ArgumentOutOfRangeException();
            }
            int temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }

        public int Find(int element)
        {
            int index = -1;
            for(int i = 0; i < this.Count; i++)
            {
                if(items[i] == element)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void Reverse()
        {
            int[] temp = new int[this.items.Length];

            for(int i = this.Count - 1, j = 0; i >= 0; i--, j++)
            {
                temp[j] = items[i];
            }
            this.items = temp;
        }
    }
}
