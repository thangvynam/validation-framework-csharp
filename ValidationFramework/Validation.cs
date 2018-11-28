using System;

namespace ValidationFramework
{
    public static class Validation
    {
        public static bool StartsWithUpper(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;
            Char ch = str[0];
            return Char.IsUpper(ch);
        }
        public static bool IsNotNullOrEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }
    }
}
