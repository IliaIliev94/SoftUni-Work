using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Telephony
{
    public class SmarthPhone : StationaryPhone, ISmartPhone
    {

        public override void Calling(string number)
        {
            if(ValidNumber(number))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        public void Browsing(string website)
        {
            if(!ValidWebsite(website))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {website}!");
            }
        }
        private bool ValidWebsite(string website)
        {
            foreach(var character in website)
            {
                if(char.IsDigit(character))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
