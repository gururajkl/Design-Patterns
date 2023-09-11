using AbstractFactoryDP.ConcreteProducts;

namespace AbstractFactoryDP.ConcreteFactory
{
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }

        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
}
