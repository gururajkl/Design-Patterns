namespace FactoryMethodDP
{
    /// <summary>
    /// The CreditCardFactory Creator class declares the factory method, 
    /// that is going to return an object of a Product class.
    /// </summary>
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        /// <summary>
        /// Returns the instance of the Product.
        /// </summary>
        /// <returns>ICreditCard of Product type.</returns>
        public ICreditCard CreateProduct()
        {
            ICreditCard creditCard = MakeProduct();
            return creditCard;
        }
    }
}
