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
        #region " String "
        #region " Nullable, Empty & Whitespace "
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
        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return !value.IsNotNullOrWhiteSpace();
        }
        #endregion

        #region " Lengths "
        public static bool IsBetweenLength(this string value, int min, int max)
        {
            if (!value.IsNotNullOrEmpty() && min == 0)
            {
                return true; // if it's null it has length 0
            }
            else if (!value.IsNotNullOrEmpty())
            {
                return false;
            }
            else
            {
                return value.Length >= min && value.Length <= max;
            }
        }
        public static bool IsMaxLength(this string value, int max)
        {
            if (!value.IsNotNullOrEmpty())
            {
                return true; // if it's null it has length 0 and that has to be less than max
            }
            else
            {
                return value.Length <= max;
            }
        }
        public static bool IsMinLength(this string value, int min)
        {
            if (!value.IsNotNullOrEmpty() && min == 0)
            {
                return true; // if it's null it has length 0
            }
            else if (!value.IsNotNullOrEmpty())
            {
                return false;
            }
            else
            {
                return value.Length >= min;
            }
        }
        public static bool IsExactLength(this string value, int length)
        {
            return value.IsBetweenLength(length, length);
        }
        #endregion

        #region " Regular Expression "
        public static bool IsEmail(this string value)
        {
            if (!value.IsNotNullOrEmpty())
            {
                return false; // if it's null it cannot possibly be an email
            }
            else
            {
                string exp = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-||_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+([a-z]+|\d|-|\.{0,1}|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])?([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))$";
                return new Regex(exp, RegexOptions.IgnoreCase).IsMatch(value);
            }
        }
        /// <summary>
        /// Checks if the current value is a password. The password must be at least 8 characters, at least 1 uppercase character, at least 1 lowercase character, at least one number and a maximum of 30 characters.
        /// It uses the following regular expression
        /// ^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$
        /// </summary>
        public static bool IsPassword(this string value)
        {
            if (!value.IsNotNullOrEmpty())
            {
                return false; // if it's null it cannot possibly be a password
            }
            else
            {
                string exp = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,30}$";

                return new Regex(exp, RegexOptions.IgnoreCase).IsMatch(value);
            }
        }
        public static bool IsRegex(this string value, string exp)
        {
            if (value.IsNotNullOrEmpty())
            {
                return false;
            }

            string check = value.ToString();

            return new Regex(exp, RegexOptions.IgnoreCase).IsMatch(check);
        }
        public static bool IsEqualTo(this string value, string compare)
        {
            if (!value.IsNotNullOrEmpty() && !compare.IsNotNullOrEmpty())
            {
                return true;
            }
            if (!value.IsNotNullOrEmpty() || !compare.IsNotNullOrEmpty())
            {
                return false;
            }
            return String.Equals(value, compare, StringComparison.Ordinal);
        }
        #endregion
        #endregion

        #region " Integer "
        public static bool IsNotZero(this int value)
        {
            return (value != 0);
        }
        public static bool Is(this int value, int compare)
        {
            return (value == compare);
        }
        public static bool IsGreaterThan(this int value, int min)
        {
            return (value >= min);
        }
        public static bool IsLessThan(this int value, int max)
        {
            return (value <= max);
        }
        public static bool IsBetween(this int value, int min, int max)
        {
            return (value <= max && value >= min);
        }

        #endregion

        #region " DateTime "
        #region " IsDate "
        public static bool IsDate(this object value)
        {
            return value.IsDate(CultureInfo.InvariantCulture);
        }
        public static bool IsDate(this object value, CultureInfo info)
        {
            return value.IsDate(CultureInfo.InvariantCulture, DateTimeStyles.None);
        }
        public static bool IsDate(this object value, CultureInfo info, DateTimeStyles styles)
        {
            if (value != null)
            {
                DateTime result;

                if (DateTime.TryParse(value.ToString(), info, styles, out result))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false; // if it's null it cannot be a date
            }
        }
        #endregion
        #region " Date Comparisons "

        public static bool IsGreaterThan(this DateTime value, DateTime compare)
        {
            return value > compare;
        }

        public static bool IsGreaterThanOrEqualTo(this DateTime value, DateTime compare)
        {
            return value >= compare;
        }

        public static bool IsLessThan(this DateTime value, DateTime compare)
        {
            return value < compare;
        }

        public static bool IsLessThanOrEqualTo(this DateTime value, DateTime compare)
        {
            return value <= compare;
        }

        public static bool IsEqualTo(this DateTime value, DateTime compare)
        {
            return value == compare;
        }

        public static bool IsBetweenInclusive(this DateTime value, DateTime from, DateTime to)
        {
            return value >= from && value <= to;
        }

        public static bool IsBetweenExclusive(this DateTime value, DateTime from, DateTime to)
        {
            return value > from && value < to;
        }

        #endregion
        #endregion

    }
}
