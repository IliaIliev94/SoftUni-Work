using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger.Factory
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            ILayout layout = null;
            if(type == "SimpleLayout")
            {
                layout = new SimpleLayout();
            }
            else
            {
                layout = new XMLLayout();
            }
            return layout;
        }
    }
}
