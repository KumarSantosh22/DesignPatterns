namespace DesignPattern.Singleton
{
    //The class should be declared sealed, ensuring it cannot be inherited.
    //This is going to be useful when you are dealing with the nested class. 
    public sealed class SingletonExampleOne
    {
        private static int Counter = 0;

        // We must create a private static variable referencing the class’s singleton instance.
        private static SingletonExampleOne Instance = null;

        //Constructor is Private means, from outside the class we cannot create an instance of this class.
        private SingletonExampleOne()
        {
            // We need to declare a constructor that should be private and parameterless.
            // This is required because it will restrict the class from being instantiated from outside the class.
            // It only instantiates from within the class.
            Counter++;
        }

        // We also need to create a public static property/method that will return the singleton instance of the class.
        public static SingletonExampleOne GetInstance()
        {
            // This method or property first checks whether an instance of the singleton class is created.
            // If the singleton instance is created, it returns that instance; otherwise, it will create an instance and then return it.
            //This version is not thread safe
            if (Instance == null)
            {
                Instance = new SingletonExampleOne();
            }
            return Instance;
        }

        public void Reset()
        {
            Counter = 0;
        }

        public int GetValue()
        {
            return Counter;
        }

        public int Increment()
        {
            return ++Counter;
        }

        public int Decrement()
        {
            return --Counter;
        }
    }
}
