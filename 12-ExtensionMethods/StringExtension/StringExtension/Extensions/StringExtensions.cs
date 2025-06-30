namespace StringExtension.Extensions
{
    public static class StringExtensions
    {
        public static string Cut(this string thisObj, int length)
        {
            if (length >= thisObj.Length)
            {
                return thisObj;
            }

            return thisObj.Substring(0, length);
        }
    }
}
