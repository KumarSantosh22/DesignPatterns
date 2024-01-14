namespace DesignPattern.Adapter
{
    public class Conversation
    {
        public void Talk()
        {
            EnglishGuy englishGuy = new EnglishGuy();
            Console.WriteLine($"e2f: {englishGuy.SpeakFrench("I")}");
            
            FrenchGuy frenchGuy = new FrenchGuy();
            Console.WriteLine($"f2e: {frenchGuy.SpeakEnglish("Je")}");            
        }
    }
}
