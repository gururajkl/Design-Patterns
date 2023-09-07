namespace SingleTonDP
{
    /// <summary>
    /// Sealed class that prevents the inheritance and avoid multiple objects for the entire project.
    /// </summary>
    public sealed class SingleTon
    {
        private static int counter = 0;
        // This static varibale creates only one instance for this class.
        private static SingleTon? instance = null;

        // For ensuring singleton in multi threading env.
        private static object lockObject = new object();

        private SingleTon()
        {
            counter++;
            Console.WriteLine(counter);
        }

        /// <summary>
        /// Public property helps to get the instance of this class from the instance local variable,
        /// Which gets the new instance only if that variable is null.
        /// </summary>
        public static SingleTon GetInstanceAsSingleTonForThisClass
        {
            get
            {
                if (instance == null)
                {
                    // Making the threads to wait here using lazy initialization.
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SingleTon();
                        }
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// Prints the provided message from the Singleton instance.
        /// </summary>
        /// <param name="message">The message to be printed.</param>
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
