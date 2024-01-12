using System.Diagnostics.Metrics;

namespace DesignPattern.Singleton
{
    public class ThreadSafeSingleton
    {
        private static int Counter=0;
        private static ThreadSafeSingleton Instance = null;

        //To use the lock, we need to create one variable
        private static readonly object InstanceLock = new object();

        private ThreadSafeSingleton()
        {
            Counter++;
        }

        public static ThreadSafeSingleton GetInstance()
        {
            //As long as one thread enters into the Critical Section, 
            //no other threads are allowed to enter the critical section
            lock (InstanceLock)
            {
                //Critical Section Start
                if (Instance == null)
                {
                    Instance = new ThreadSafeSingleton();
                }
                //Critical Section End
                return Instance;
            }
        }

        public void Reset()
        {
            Counter = 0;
        }

        public int GetValue()
        {
            return Counter;
        }

    }
}
