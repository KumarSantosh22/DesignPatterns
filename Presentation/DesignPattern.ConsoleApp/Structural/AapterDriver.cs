using DesignPattern.Adapter;

namespace DesignPattern.ConsoleApp.Structural
{
    public class AapterDriver
    {
        Conversation conversation = new Conversation();

        public void Drive()
        {
            conversation.Talk();
        }
    }
}
