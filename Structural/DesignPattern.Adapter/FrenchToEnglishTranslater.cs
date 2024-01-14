namespace DesignPattern.Adapter
{
    public class FrenchToEnglishTranslater : ITranslater
    {
        public string Translate(string word)
        {
            return _f2e[word];
        }

        Dictionary<string, string> _f2e = new()
        {
            {"Je", "I" },
            {"suis", "am" }
        };
    }
}
