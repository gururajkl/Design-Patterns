using AbstractFactoryDP.ConcreteFactory;

namespace AbstractFactoryDP
{
    internal class Program
    {
        static void Main()
        {
            // Regular Product.
            IVehicleFactory regularVehiclefactory = new RegularVehicleFactory();
            IBike regularBike = regularVehiclefactory.CreateBike();
            regularBike.GetDetails();
            ICar regularCar = regularVehiclefactory.CreateCar();
            regularCar.GetDetails();

            // Sports Product.
            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
            IBike sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetDetails();
            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();
        }
    }
}