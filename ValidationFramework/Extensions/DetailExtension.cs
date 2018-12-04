namespace ValidationFramework.Extensions
{
    public static class DetailExtension
    {
        public static bool IsNotNullOrEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }
    }
}
