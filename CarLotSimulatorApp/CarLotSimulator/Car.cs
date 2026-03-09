using System;
using System.Dynamic;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }
   

    public void MakeEngineNoise()
    {
        Console.WriteLine($"The engine makes a {EngineNoise} sound");
    }

    public void MakeHonkNoise()
    {
        Console.WriteLine($"The horn makes a {HonkNoise} sound");
    }

    public Car()
    {
        CarLot.numberOfCars++;
    }
}