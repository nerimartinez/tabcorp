using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBreweryServices;
using TheBreweryModels;

namespace TheBreweryTests
{
    [TestClass]
    public class SensorsServiceTest
    {
        private ISensorsService sensorsService;
        private BeerTruck beerTruck;

        public SensorsServiceTest() {
            sensorsService = new SensorsServices();
            beerTruck = new BeerTruck();
        }

        [TestMethod]
        public void UpdateTemperaturesTest()
        {
            var previousValue = beerTruck;
            BeerTruck result = sensorsService.UpdateTemperatures(beerTruck);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(BeerTruck));
            Assert.AreEqual(previousValue.beersContainers[0].beer, result.beersContainers[0].beer);
            Assert.AreNotEqual(previousValue.beersContainers, result.beersContainers[0]); 
        }
    }
}
