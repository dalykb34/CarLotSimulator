using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();
            

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            

            var v1 = new Car();
            v1.Year = 2019;
            v1.Make = "Ford";
            v1.Model = "Ranger";
            v1.EngineNoise = "pop pop";
            v1.HonkNoise = "get out the way";
            v1.IsDriveable = true;

            lot.Cars.Add(v1);

            var a2 = new Car();
            a2.Year = 3090;
            a2.Make = "Tesla";
            a2.Model = "Model x";
            a2.EngineNoise = "Shhhh!";
            a2.HonkNoise = "energize";
            a2.IsDriveable = true;

            lot.Cars.Add(a2);

            var b1 = new Car();
            b1.Year = 1969;
            b1.Make = "Chevy";
            b1.Model = "Corvette";
            b1.EngineNoise = "Vroom";
            b1.HonkNoise = "beep beep";
            b1.IsDriveable = false;

            lot.Cars.Add(b1);

            var z3 = new Car()
            {
                Year = 2020,
                Make = "BMW",
                Model = "z3",
                EngineNoise = "swoosh",
                HonkNoise = "meep",
                IsDriveable = true
            };

            lot.Cars.Add(z3);

            var q4 = new Car(2012, "GMC", "2500", "brumm", "boom", true);

            lot.Cars.Add(q4);

            v1.MakeEngineNoise(v1.EngineNoise);
            a2.MakeEngineNoise(a2.EngineNoise);
            b1.MakeEngineNoise(b1.EngineNoise);
            z3.MakeEngineNoise(z3.EngineNoise);
            q4.MakeEngineNoise(q4.EngineNoise);

            v1.MakeHonkNoise(v1.HonkNoise);
            a2.MakeHonkNoise(a2.HonkNoise);
            b1.MakeHonkNoise(b1.HonkNoise);
            z3.MakeHonkNoise(z3.HonkNoise);
            q4.MakeHonkNoise(q4.HonkNoise);

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }


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
