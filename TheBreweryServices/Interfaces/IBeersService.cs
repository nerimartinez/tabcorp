using TheBreweryModels;

namespace TheBreweryServices
{
    public interface IBeersService
    {
        /// <summary>
        /// Gets an array of beers containers with it's temperature
        /// </summary>
        /// <returns></returns>
        BeerContainer[] getTemperatures();
    }
}
