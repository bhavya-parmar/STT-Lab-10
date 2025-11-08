using System;

class Vehicle
{
    protected int speed;
    protected int fuel;

    public Vehicle(int s, int f)
    {
        speed = s;
        fuel = f;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}");
    }

    public virtual void Drive()
    {
        fuel -= 5;
        Console.WriteLine("Vehicle is moving...");
    }
}

class Car : Vehicle
{
    private int passengers;

    public Car(int s, int f, int p) : base(s, f)
    {
        passengers = p;
    }

    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine("Car is moving with passenger.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Passengers: {passengers}");
    }
}

class Truck : Vehicle
{
    private int cargoWeight;

    public Truck(int s, int f, int c) : base(s, f)
    {
        cargoWeight = c;
    }

    public override void Drive()
    {
        fuel -= 15;
        Console.WriteLine("Truck is moving with cargo.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Cargo: {cargoWeight}");
    }
}

class Program2
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Vehicle(60, 100);
        vehicles[1] = new Car(80, 120, 4);
        vehicles[2] = new Truck(70, 150, 2000);

        foreach (Vehicle v in vehicles)
        {
            v.Drive();
            v.ShowInfo();
        }
        Console.ReadKey(); // to see output before console window closes
    }
}
