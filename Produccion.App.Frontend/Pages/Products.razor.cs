using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Produccion.App.Frontend.Pages
{

    public partial class Products
    {
        private String maxlength = "10";
        private string placeholder = "Buscar Cliente";
        private string required = "required";
        private string size = "20";
        private Dictionary<string, object> InputAttributes { get; set; } = new() { { "maxlength", "10" }, { "placeholder", "Buscar Cliente" }, { "required", "required" }, { "size", "20" } };

        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }

    }
}