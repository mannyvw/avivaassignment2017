using System;
using System.Collections.Generic;

namespace Aviva.Model
{
    public class Coord
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "lat")]
        public double Latitude { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "lon")]
        public double Longitude { get; set; }
    }

    public class WeatherReport 
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public int UID { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "main")]
        public string Main { get; set; }
		[Newtonsoft.Json.JsonProperty(PropertyName = "description")]
		public string Description { get; set; }
		[Newtonsoft.Json.JsonProperty(PropertyName = "icon")]
		public string Icon { get; set; }
	}

    public class Main
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "temp")]
        public double Temperature { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "pressure")]
        public double Pressure { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "humidity")]
        public double Humidity { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "temp_min")]
        public double MinTemperature { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "temp_max")]
        public double MaxTemperature { get; set; }
    }

    public class WeatherResponse
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "coord")]
        public Coord Coordinates { get; set;}
	    [Newtonsoft.Json.JsonProperty(PropertyName = "weather")]
	    public List<WeatherReport> Report { get; set; }
		[Newtonsoft.Json.JsonProperty(PropertyName = "main")]
		public Main Main { get; set; }
	}
}
