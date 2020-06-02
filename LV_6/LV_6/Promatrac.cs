using System;
using System.Collections.Generic;
using System.Text;

namespace LV_6
{
    // Promtatrac hahahahhahahahahahahahaah
    public interface WeatherSubject
    {
        void AddObserver(WeatherObserver weatherObserver);
        void RemoveObserver(WeatherObserver weatherObserver);
        void Notify();
    }
    public interface WeatherObserver
    {
        void Update(int temperature);
    }

        public class WeatherStation : WeatherSubject
        {
            List<WeatherObserver> weatherObservers;
            int temperature;
            public WeatherStation(int temperature)
            {
                weatherObservers = new List<WeatherObserver>();
                this.temperature = temperature;
                Console.WriteLine("Weather station setting temperature to " + temperature);
            }
            public void AddObserver(WeatherObserver weatherObserver)
            {
                weatherObservers.Add(weatherObserver);
            }
            public void RemoveObserver(WeatherObserver weatherObserver)
            {
                weatherObservers.Remove(weatherObserver);
            }

            public void Notify()
            {
                foreach (WeatherObserver observer in weatherObservers)
                {
                    observer.Update(temperature);
                }
            }
            public void SetTemperature(int newTemperature)
            {
                Console.WriteLine("Weather station setting temperature to " + newTemperature);
                temperature = newTemperature;
                Notify();
            }
            public class HomeThermostat : WeatherObserver
            {
                bool HeatingIsOn = false;
                bool CoolingIsOn = true;
                const int HeatingThreshold = 15;
                const int CoolingThreshold = 25;
                public void Update(int temperature)
                {
                    if (temperature < HeatingThreshold) { StartHeating(); }
                    else if (temperature > CoolingThreshold) { StartCooling(); }
                    else { StopAll(); }
                }
                private void StartHeating()
                {
                    Console.WriteLine("Now heating"); HeatingIsOn = true; CoolingIsOn = false;
                }
                private void StartCooling()
                {
                    Console.WriteLine("Now cooling.");
                }
                private void StopAll()
                {
                    Console.WriteLine("Stop all.");
                }
            }
        }
    
}
