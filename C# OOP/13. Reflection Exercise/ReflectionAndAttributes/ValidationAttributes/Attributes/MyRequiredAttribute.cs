using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            string property = (string)Type.GetType(obj.ToString()).GetProperty("Name").GetValue(obj);
            if(property != null)
            {
                return true;
            }
            return false;
        }
    }
}
