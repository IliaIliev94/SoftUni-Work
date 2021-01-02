using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public StackOfStrings(IEnumerable<string> words) : base(words)
        {

        }

        public bool IsEmpty()
        {
            bool isEmpty = false;
            if(this.Count == 0)
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        public void AddRange(IEnumerable<string> input)
        {
            foreach(var word in input)
            {
                this.Push(word);
            }
        }
    }
}
