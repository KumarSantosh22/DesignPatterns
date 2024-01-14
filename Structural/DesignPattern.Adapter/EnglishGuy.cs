namespace DesignPattern.Adapter
{
    public class EnglishGuy
    {
        public string SpeakFrench(string word)
        {
            ITranslater translater = new EnglishToFrenchTranslater();
            return translater.Translate(word);
        }        
    }
}
