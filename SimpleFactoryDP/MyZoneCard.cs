namespace SimpleFactoryDP
{
    public class MyZoneCard : ICard
    {
        public void GetCardAnnualCharges()
        {
            Console.WriteLine("0 annual charges");
        }

        public void GetCardLimit()
        {
            Console.WriteLine("Card limit - 32k Per Month!");
        }

        public void GetCardType()
        {
            Console.WriteLine("MyZone - Free credit card");
        }
    }
}
