using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
namespace ValidationFramework.Extensions
{
    public static class DetailExtension
    {
        public static bool IsNotNullOrEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }
        public static bool HaveAnyUpperCharacter(this string str)
        {
            if (str == null)
                return false;
            return str.Any(char.IsUpper);
        }
    }
}
