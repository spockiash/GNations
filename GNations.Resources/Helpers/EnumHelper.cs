using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GNations.Resources.Helpers
{
    public static class EnumHelper
    {
        public static string GetDescription(this Enum value)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return ((DescriptionAttribute)Attribute.GetCustomAttribute(
                value.GetType().GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Single(x => x.GetValue(null).Equals(value)),
                typeof(DescriptionAttribute)))?.Description ?? value.ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }
    }
}
