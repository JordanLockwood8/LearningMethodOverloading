namespace Method_overload
{
    internal static class MethodsHelpers
    {
        public static string Add(int a, int b, bool istrue)
        {
            if (a + b > 1 && istrue)
            {
                return $"{a + b} Dollars ";
            }
            else
            {
                return $"{a + b} Dollar";
            }

        }
    }
}