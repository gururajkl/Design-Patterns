namespace FactoryMethodDP
{
    // Interface that has some operations that all concrete must implement.
    public interface ICreditCard
    {
        string GetCardType();
        int GetCardLimit();
        int GetAnnualCharges();
    }
}
