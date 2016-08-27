namespace UmbracoSwag.Core.Extensions
{
    public static class StringExtensions
    {
        public static string FallbackTo(this string original, string fallback)
        {
            if (string.IsNullOrEmpty(original))
                return fallback;
            return original;
        }
    }
}
