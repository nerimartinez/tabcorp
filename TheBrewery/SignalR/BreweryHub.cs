using Microsoft.AspNet.SignalR;
using System.Timers;
using TheBreweryServices;

namespace TheBrewery.SignalR
{
    public class BreweryHub : Hub
    {
        private IBeersService sensorService;
        private Timer timer;

        public BreweryHub() {
            sensorService = new BeersService();
        }

        public void InitTimer() {
            timer = new Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(CheckTemperatures);
            timer.Enabled = true;
            timer.Start();
        }

        private void CheckTemperatures(object source, ElapsedEventArgs e)
        {            
            Clients.Caller.beersTemps(sensorService.getTemperatures());
        }
    }
}