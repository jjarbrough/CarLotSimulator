using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public Car()
        {
            CarLot.numberOfCars++;
        }


        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDrivable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
            CarLot.numberOfCars++;
        }
        public void MakeEngineNoise(string a)
        {
            EngineNoise = a;
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise(string a) 
        {
            HonkNoise = a;
            Console.WriteLine(HonkNoise);
        }

    }  
}
