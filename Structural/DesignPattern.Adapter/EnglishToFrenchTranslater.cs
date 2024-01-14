namespace DesignPattern.Adapter
{
    public class EnglishToFrenchTranslater: ITranslater
    {
        public string Translate(string word)
        {
            return _f2e[word];
        }

        Dictionary<string, string> _f2e = new()
        {
            {"I", "Je" },
            {"am", "suis" }
        };
    }
}
