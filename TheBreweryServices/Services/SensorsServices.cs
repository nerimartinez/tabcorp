using System;
using TheBreweryModels;

namespace TheBreweryServices
{   
    /// <summary>
    /// This is just a simulation of updating temperatures using real sensors
    /// </summary>
    public class SensorsServices : ISensorsService
    {
        private Random random = new Random();

        public BeerTruck UpdateTemperatures(BeerTruck truck)
        {
            for (int i = 0; i < truck.beersContainers.Length; i++)
            {
                truck.beersContainers[i].currentTemp += TempVariation();
            }
            return truck;
        }

        private float TempVariation()
        {
            int randomNumber = random.Next(0, 100000) % 3;
            switch (randomNumber)
            {
                case 0: return 0;
                case 1: return (float)-0.1;
                default: return (float)0.1;
            }
        }

    }
}
