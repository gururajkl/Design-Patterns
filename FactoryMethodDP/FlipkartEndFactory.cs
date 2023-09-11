namespace FactoryMethodDP
{
    public class FlipkartEndFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard flipkartEnd = new FlipkartEnd();
            return flipkartEnd;
        }
    }
}
