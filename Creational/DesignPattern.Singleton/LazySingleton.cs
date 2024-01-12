namespace DesignPattern.Singleton
{
    public class LazySingleton
    {
        private static int Counter = 0;

        // The private static instance ensures lazy initialization.
        private static Lazy<LazySingleton> instance = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {
            Counter++;
        }

        public static LazySingleton GetInstance()
        {
            return instance.Value;
        }

        public int GetValue()
        {
            return Counter;
        }
    }
}
