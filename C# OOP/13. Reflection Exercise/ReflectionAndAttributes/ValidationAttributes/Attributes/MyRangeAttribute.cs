using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int minvalue, int maxvalue)
        {
            this.minValue = minvalue;
            this.maxValue = maxvalue;
        }
        public override bool IsValid(object obj)
        {
            return (int)obj >= minValue && (int)obj <= maxValue;
        }
    }
}
