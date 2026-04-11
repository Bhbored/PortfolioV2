namespace Portfolio.Helpers
{
    public static class Capitalizer
    {
        public static string CapitalizeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return name;

            List<string> words = name.Trim().Split(' ').ToList();

            List<string> capitalizedWords = new List<string>();

            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    string capitalized = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                    capitalizedWords.Add(capitalized);
                }
            }

            return string.Join(" ", capitalizedWords);
        }
    }
}
