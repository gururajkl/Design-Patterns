namespace FactoryMethodDP
{
    internal class Program
    {
        static void Main()
        {
            // Using Factorys of the Product class to get the instance of the Product.
            ICreditCard card = new MyZoneFactory().CreateProduct();
            if (card != null)
            {
                Console.WriteLine($"Card Type - {card.GetCardType()}");
                Console.WriteLine($"Card Annual Charges - {card.GetAnnualCharges()}");
                Console.WriteLine($"Card Limit - {card.GetCardLimit()}");
            }
        }
    }
}