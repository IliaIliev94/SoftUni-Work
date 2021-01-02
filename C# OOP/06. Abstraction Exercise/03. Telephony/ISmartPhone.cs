using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Telephony
{
    public interface ISmartPhone : IStationaryPhone
    {
        void Browsing(string website);
    }
}
