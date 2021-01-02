using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            MyRequiredAttribute myRequiredAttribute = (MyRequiredAttribute)Type
                .GetType(obj.ToString()).GetProperty("Name")
                .GetCustomAttribute(typeof(MyRequiredAttribute));

            bool test1 = myRequiredAttribute.IsValid(obj);

            MyRangeAttribute myRangeAttribute = (MyRangeAttribute)Type
                .GetType(obj.ToString()).GetProperty("Age")
                .GetCustomAttribute(typeof(MyRangeAttribute));

            bool test2 = myRangeAttribute.IsValid(Type.GetType(obj.ToString()).GetProperty("Age").GetValue(obj));

            return test1 && test2;
        }
    }
}
