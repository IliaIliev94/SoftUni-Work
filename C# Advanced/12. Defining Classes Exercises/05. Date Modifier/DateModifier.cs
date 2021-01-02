using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Date_Modifier
{
    public static class DateModifier
    {

        public static double Difference(DateTime date1, DateTime date2)
        {
            return Math.Abs((date1 - date2).TotalDays);
        }
    }
}
