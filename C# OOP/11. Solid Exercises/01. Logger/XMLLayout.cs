using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public class XMLLayout : ILayout
    {
        public string Format =>
@"<log>
    <date>{0}</date>
    <level>{1}</level>
    <message>{2}</message>
</log>";
    }
}
