using AbstractFactoryDP.ConcreteFactory;

namespace AbstractFactoryDP
{
    /// <summary>
    /// Abstract Factory Component in this example.
    /// 
    /// Abstract Product A: IBike.cs
    /// Abstract Product B: ICar.cs
    /// 
    /// Product A1: RegularBike.cs
    /// Product B1: RegularCar.cs
    /// 
    /// Product A2: SportsBike.cs
    /// Product B2: SportsCar.cs
    /// 
    /// Abstract Factory: IVehicleFactory.cs
    /// 
    /// Concrete Factory1: RegularVehicleFactory.cs
    /// Concrete Factory2: SportsVehicleFactory.cs
    /// 
    /// Clent: Program.cs
    /// </summary>
    public class Program
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