namespace FactoryMethodDP
{
    public class FlipkartEnd : ICreditCard
    {
        public int GetAnnualCharges()
        {
            return 1000;
        }

        public int GetCardLimit()
        {
            return 200000;
        }

        public string GetCardType()
        {
            return "Flipkart card - Dhamaka";
        }
    }
}
