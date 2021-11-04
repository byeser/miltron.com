using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miltron.com.ui.Models.Weather
{
    public class WeatherResponse
    {    
        public float temperature { get; set; }
        public float humidity { get; set; }
        public float pressure { get; set; }
        public Precipitation precipitation { get; set; }
        public DateTime time { get; set; }
        public Wind wind { get; set; }
    }

    public class Precipitation
    {
        public float probability { get; set; }
        public bool rain { get; set; }
        public bool snow { get; set; }
        public bool sleet { get; set; }
        public bool hail { get; set; }
    }

    public class Wind
    {
        public string direction { get; set; }
        public float angle { get; set; }
        public float speed { get; set; }
    }

}
