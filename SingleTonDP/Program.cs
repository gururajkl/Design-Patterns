namespace SingleTonDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            SingleTon s1 = SingleTon.GetInstanceAsSingleTonForThisClass;
            s1.PrintMessage("S1 message");

            SingleTon s2 = SingleTon.GetInstanceAsSingleTonForThisClass;
            s2.PrintMessage("S2 message");
        }
    }
}