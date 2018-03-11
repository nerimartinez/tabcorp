using TheBreweryModels;

namespace TheBreweryServices
{
    public interface ISensorsService
    {
        /// <summary>
        /// Updates the temperatures of the beers containers within a truck
        /// </summary>
        /// <param name="truck"></param>
        /// <returns></returns>
        BeerTruck UpdateTemperatures(BeerTruck truck);
    }
}
