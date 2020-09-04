﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make =make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDrivable;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set;}
        public string HonkNoise { get; set;}
        public bool IsDriveable { get; set;}

        public void MakeEngineNoise(string enigeNoise)
        {
            Console.WriteLine(enigeNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }
    }
    
    

    
}
