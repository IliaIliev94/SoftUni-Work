using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger.Factory
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
