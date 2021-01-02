using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public RandomList () : base()
        {

        }
        public string RandomString()
        {
            Random rnd = new Random();
            string s = base[rnd.Next(0, base.Count)];
            base.Remove(s);
            return s;
        }
    }
}
