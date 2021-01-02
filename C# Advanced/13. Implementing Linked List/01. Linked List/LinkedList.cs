using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01._Linked_List
{
    class LinkedList : IEnumerable<int>
    {
        public Node First { get; set; }

        public Node Last { get; set; }

        public int Count { get; private set; }

        public LinkedList()
        {
            this.Count = 0;
        }

        public LinkedList(IEnumerable<int> collection) : this()
        {
            foreach(var item in collection)
            {
                this.AddLast(item);
            }
        }

        public void AddFirst(int element)
        {
            Node newNode = new Node(element);
            if(this.First != null)
            {
                newNode.Next = this.First;
                this.First.Previous = newNode;
            }
            else
            {
                this.Last = newNode;
            }
            this.First = newNode;
            Count++;

        }
        public void AddLast(int element)
        {
            Node newNode = new Node(element);
            if(this.Last != null)
            {
                newNode.Previous = this.Last;
                this.Last.Next = newNode;
            }
            else
            {
                this.First = newNode;
            }

            this.Last = newNode;
            Count++;
        }

        public bool Contains(int value)
        {
            Node current = this.First;

            while(current != null)
            {
                if(current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public Node Find(int value)
        {
            Node current = this.First;
            Node result = null;
            while(current != null)
            {
                if(current.Value == value)
                {
                    result = current;
                    break;
                }
                current = current.Next;
            }
            return result;
        } 

        public void AddAfter(Node node, int value)
        {
            if(node == null)
            {
                throw new ArgumentNullException("Node cannot be null!");
            }
            Node newNode = new Node(value);
            node.Next.Previous = newNode;
            newNode.Next = node.Next;
            newNode.Previous = node;
            node.Next = newNode;
            Count++;
        }

        public void AddBefore(Node node, int value)
        {
            if(node == null)
            {
                throw new ArgumentNullException("Node cannot be null!");
            }
            Node newNode = new Node(value);
            if(node.Previous != null)
            {
                node.Previous.Next = newNode;
                newNode.Previous = node.Previous;
            }
            else
            {
                this.First = newNode;
            }
            newNode.Next = node;
            node.Previous = newNode;
            Count++;
        }

        public void ForEach(Action<Node> action)
        {
            Node current = this.First;

            while(current != null)
            {
                action(current);
                current = current.Next;
            }
        }

        public void Remove(Node node)
        {
            if(node == null)
            {
                throw new ArgumentNullException("Node cannot be null!");
            }
            if(this.First == node)
            {
                RemoveFirst();
            }
            else if(this.Last == node)
            {
                RemoveLast();
            }
            else
            {
                Node current = this.First;

                while (node != null)
                {
                    if (current == node)
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                        current.Next = null;
                        current.Previous = null;
                        break;
                    }
                    current = current.Next;
                }
                Count--;
            }
            
        }

        public void Remove(int value)
        {
            Node current = this.Find(value);
            if(current != null)
            {
                Remove(current);
            }
        }

        public void RemoveFirst()
        {
            if(this.First != null)
            {
                if(this.Count == 1)
                {
                    this.First = this.Last = null;
                }
                else
                {

                    this.First = this.First.Next;
                    this.First.Previous.Next = null;
                    this.First.Previous = null;

                }
                Count--;
            }
            
        }

        public void RemoveLast()
        {
            if(this.Last != null)
            {
                if(this.Count == 1)
                {
                    this.Last = this.First = null;
                }
                else
                {
                    this.Last = this.Last.Previous;
                    this.Last.Next.Previous = null;
                    this.Last.Next = null;
                }
                Count--;
            }

        }

        public int[] ToArray()
        {
            int[] result = new int[this.Count];
            Node current = this.First;
            for (int i = 0; i < result.Length; i++, current = current.Next)
            {
                result[i] = current.Value;
            }
            return result;
        }
        public IEnumerator<int> GetEnumerator()
        {
            Node current = this.First;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
