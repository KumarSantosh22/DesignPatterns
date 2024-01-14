namespace DesignPattern.Adapter
{
    public class FrenchGuy
    {
        public string SpeakEnglish(string word)
        {
            ITranslater translater = new FrenchToEnglishTranslater();
            return translater.Translate(word);
        }
    }
}
