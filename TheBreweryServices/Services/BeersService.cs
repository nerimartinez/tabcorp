using TheBreweryModels;

namespace TheBreweryServices
{
    public class BeersService : IBeersService
    {
        private BeerTruck truck = new BeerTruck();
        private SensorsServices sensorsService = new SensorsServices();

        public BeerContainer[] getTemperatures() {
            sensorsService.UpdateTemperatures(truck);
            return truck.beersContainers;
        }               
    }
}
