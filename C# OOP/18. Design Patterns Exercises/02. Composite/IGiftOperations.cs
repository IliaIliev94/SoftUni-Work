using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Composite
{
    public interface IGiftOperations
    {
        void Add(GiftBase gift);

        void Remove(GiftBase gift);
    }
}
