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
                    instance = new SingleTon();
                }
                return instance;
            }
        }

        /// <summary>
        /// Prints the passed message from the object.
        /// </summary>
        /// <param name="message">Anything can be passed.</param>
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
