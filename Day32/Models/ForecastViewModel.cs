namespace Day32.Models
{
    public class ForecastViewModel
    {
        public ForecastViewModel(string name, string temperature, string wind, string forecast)
        {
            Name = name;
            Temperature = temperature;
            Wind = wind;
            Forecast = forecast;
        }

        public string Name { get; }
        public string Temperature { get; }
        public string Wind { get; }
        public string Forecast { get; }
    }
}
