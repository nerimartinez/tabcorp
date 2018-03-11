using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBreweryServices;
using TheBreweryModels;

namespace TheBreweryTests
{
    [TestClass]
    public class BeersServiceTest
    {
        private IBeersService beersService;

        public BeersServiceTest() {
            beersService = new BeersService();
        }

        [TestMethod]
        public void GetTemperaturesTest()
        {
            var result = beersService.getTemperatures();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(BeerContainer[]));
            Assert.IsTrue(result.Length > 0);              
        }
    }
}
