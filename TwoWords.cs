namespace TwoWords
{
    internal static class TwoWords
    {
        internal static bool CheckForReconstruction(string firstWord, string secondWord)
        {
            var firstCharArray = firstWord.ToCharArray().ToList();
            foreach (var ch in secondWord.ToCharArray())
            {
                if (firstCharArray.Contains(ch))
                {
                    firstCharArray.Remove(ch);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        internal static char[] FindIntersection(string firstWord, string secondWord)
        {
            var firstArray = firstWord.ToCharArray();
            var secondArray = secondWord.ToCharArray();
            return firstArray.Intersect(secondArray).ToArray();
        }
    }
}
