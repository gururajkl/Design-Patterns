namespace SimpleFactoryDP
{
    public class Program
    {
        static void Main()
        {
            ICard? card = CreditCardFactory.GetCreditCardDetails("myzone");

            if (card == null)
            {
                Console.WriteLine("Card not found!");
            }
            else
            {
                card.GetCardType();
                card.GetCardAnnualCharges();
                card.GetCardLimit();
            }
            Console.ReadKey();
        }
    }
}