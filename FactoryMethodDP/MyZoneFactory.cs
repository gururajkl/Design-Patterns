namespace FactoryMethodDP
{
    public class MyZoneFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard myZoneCard = new MyZone();
            return myZoneCard;
        }
    }
}
