
namespace TheBreweryModels
{
    /// <summary>
    /// This class represents a truck and it's load, that's why it has harcoded data
    /// </summary>
    public class BeerTruck
    {
        public BeerContainer[] beersContainers { get; set;}
                
        public BeerTruck() {
            beersContainers = new BeerContainer[5];
            beersContainers[0] = new BeerContainer() { beer = new Beer() { Name = "Beer 1", minTemp = 4, maxTemp = 6 }, currentTemp = 5 };
            beersContainers[1] = new BeerContainer() { beer = new Beer() { Name = "Beer 2", minTemp = 5, maxTemp = 6 }, currentTemp = 5 };
            beersContainers[2] = new BeerContainer() { beer = new Beer() { Name = "Beer 3", minTemp = 4, maxTemp = 7 }, currentTemp = 6 };
            beersContainers[3] = new BeerContainer() { beer = new Beer() { Name = "Beer 4", minTemp = 6, maxTemp = 8 }, currentTemp = 7 };
            beersContainers[4] = new BeerContainer() { beer = new Beer() { Name = "Beer 5", minTemp = 3, maxTemp = 5 }, currentTemp = 4 };
        }
    }
}
