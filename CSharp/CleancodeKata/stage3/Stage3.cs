namespace CleancodeKata.stage3
{
    /**
     * Remove all the code duplications.
     */
    public static class Stage3
    {
        public static string DoTheThing(string input)
        {
            return ReplaceStringInThing(input, input.Length % 2 == 0 ? "even": "odd");
        }

        private static string ReplaceStringInThing(string input, string prefix)
        {
            string result = input.Replace('A', 'a');
            result = result.Replace('E', 'e');
            result = result.Replace('I', 'i');
            result = result.Replace('O', 'o');
            result = result.Replace('U', 'u');
            result = result.Replace('Y', 'y');
            return (result.Length < 10 ? "short_" : "long_") + prefix + "_" + result;
        }
    }
}