namespace AbstractFactoryDP
{
    // The Abstract Factory interface declares a set of methods that return different abstract products.
    public interface IVehicleFactory
    {
        /// <summary>
        /// Abstract Product of IBike.
        /// </summary>
        /// <returns>RegularBike || SportsBike</returns>
        IBike CreateBike();
        /// <summary>
        /// Abstract Product of ICar.
        /// </summary>
        /// <returns>RegularCar || Sportscar</returns>
        ICar CreateCar();
    }
}
