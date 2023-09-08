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

        // Using eager loading, can pass this instance in property without double-check and it's tread
        // Safe.
        private static readonly object eagerInit = new SingleTon();

        // Using lazy loading, can pass this instance as lazyInit.Value in property without double-check and it's tread
        // Safe.
        private static readonly Lazy<SingleTon> lazyInit = new Lazy<SingleTon>(() => new SingleTon());

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
                    // Use double-check locking to ensure thread safety while creating the instance.
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
