namespace FactoryMethodDP
{
    public class MyZone : ICreditCard
    {
        public int GetAnnualCharges()
        {
            return 0;
        }

        public int GetCardLimit()
        {
            return 32000;
        }

        public string GetCardType()
        {
            return "My zone card - Free use";
        }
    }
}
