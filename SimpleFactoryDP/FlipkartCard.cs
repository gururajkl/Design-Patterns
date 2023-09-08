namespace SimpleFactoryDP
{
    public class FlipkartCard : ICard
    {
        public void GetCardAnnualCharges()
        {
            Console.WriteLine("900 per month charges");
        }

        public void GetCardLimit()
        {
            Console.WriteLine("Card limit - 3 lakh per month");
        }

        public void GetCardType()
        {
            Console.WriteLine("Flipakart card - Unlimited benifits");
        }
    }
}
