using System.Collections.Generic;
namespace Lab9Csh;
public class Garage
{
    private List<Car> cars = [];

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void WashAll(Washer washer)
    {
        foreach (var car in cars)
        {
            car.Wash(washer);
        }
    }
}

public class Car(string name)
{
    public string Name { get; set; } = name;

    public void Wash(Washer washer)
    {
        washer.Wash(this);
    }
}

public class Washer
{
    public void Wash(Car car)
    {
        System.Console.WriteLine($"Моем автомобиль: {car.Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new("Acura");
        Car car2 = new("Honda");
        Car car3 = new("Isuzu");

        Garage garage = new();
        garage.AddCar(car1);
        garage.AddCar(car2);
        garage.AddCar(car3);

        Washer washer = new();

        garage.WashAll(washer);
    }
}
