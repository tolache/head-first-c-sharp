namespace Chapter_13_MyExtensions
{
    public static class HumanExtensions
    {
        public static bool IsDistressCall(this string s)
        {
            if (s.Contains("Help!"))
                return true;
            return false;
        }
    }
}