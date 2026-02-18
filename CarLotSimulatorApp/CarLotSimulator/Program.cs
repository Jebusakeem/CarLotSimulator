using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            var car1 = new Car();
            car1.Year = 2012;
            car1.Make = "Volvo";
            car1.Model = "XC90";
            car1.EngineNoise = "vrrrrmmm";
            car1.HonkNoise = "onk onk";
            car1.IsDriveable = true;

            var car2 = new Car();
            car2.Year = 2018;
            car2.Make = "Audi";
            car2.Model = "SQ7";
            car2.EngineNoise = "yrrrnnn";
            car2.HonkNoise = "onk onk";
            car2.IsDriveable = true;
            
            var car3 = new Car();
            car3.Year = 2022;
            car3.Make = "Dodge";
            car3.Model = "Dakota";
            car3.EngineNoise = "clunk clunk";
            car3.HonkNoise = "beep beep";
            car3.IsDriveable = false;
            
            car1.ShowData();
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            
            car2.ShowData();
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            
            car3.ShowData();
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
