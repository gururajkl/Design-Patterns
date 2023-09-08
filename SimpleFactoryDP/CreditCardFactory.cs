namespace SimpleFactoryDP
{
    public class CreditCardFactory
    {
        public static ICard? GetCreditCardDetails(string cardName)
        {
            ICard? card = null;

            switch (cardName)
            {
                case "myzone":
                    card = new MyZoneCard();
                    break;
                case "flipkart":
                    card = new FlipkartCard();
                    break;
                default:
                    card = null;
                    break;
            }

            return card;
        }
    }
}
