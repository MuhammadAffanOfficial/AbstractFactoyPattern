// Abstract products
public interface IEngine
{
    void Start();
}

public interface ITire
{
    void Roll();
}

// Concrete products for Car
public class CarEngine : IEngine
{
    public void Start() => Console.WriteLine("Car engine started");
}

public class CarTire : ITire
{
    public void Roll() => Console.WriteLine("Car tires rolling");
}

// Concrete products for Bike
public class BikeEngine : IEngine
{
    public void Start() => Console.WriteLine("Bike engine started");
}

public class BikeTire : ITire
{
    public void Roll() => Console.WriteLine("Bike tires rolling");
}

// Abstract factory interface
public interface IVehicleFactory
{
    IEngine CreateEngine();
    ITire CreateTire();
}

// Concrete factories
public class CarFactory : IVehicleFactory
{
    public IEngine CreateEngine() => new CarEngine();
    public ITire CreateTire() => new CarTire();
}

public class BikeFactory : IVehicleFactory
{
    public IEngine CreateEngine() => new BikeEngine();
    public ITire CreateTire() => new BikeTire();
}

// Usage
class Program
{
    static void Main()
    {
        IVehicleFactory factory = new CarFactory();
        IEngine engine = factory.CreateEngine();
        ITire tire = factory.CreateTire();

        engine.Start(); // Output: Car engine started
        tire.Roll();    // Output: Car tires rolling
    }
}