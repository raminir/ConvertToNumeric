using System.Text;

namespace Infrastructure
{
    public static class Utility
    {
        static Utility()
        {
        }

        public static string? ConvertToNumeric(string text)
        {
            var result = new StringBuilder(text.Length);
            foreach (char ch in text)
            {
                result.Append(char.IsDigit(ch) ? char.GetNumericValue(ch) : ch.ToString());
            }
            return result.ToString();
        }
    }
}
