namespace UmbracoSwag.Core.Extensions
{
    public static class StringExtensions
    {2345
        public static string FallbackTo(this string original, string fallback)
        {faasdf
            if (string.IsNullOrEmpty(original))
                return fallback;
            return original;
        }52345
    }
}
q323
