using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miltron.com.ui.Models.Rocket
{
    public class RocketResponse
    { 
        public string id { get; set; }
        public string model { get; set; }
        public long mass { get; set; }
        public Payload payload { get; set; }
        public Telemetry telemetry { get; set; }
        public string status { get; set; }
        public Timestamps timestamps { get; set; }
        public Int64 altitude { get; set; }
        public Int64 speed { get; set; }
        public Int64 acceleration { get; set; }
        public Int64 thrust { get; set; }
        public Int64 temperature { get; set; }
    }

    public class Payload
    {
        public string description { get; set; }
        public int weight { get; set; }
    }

    public class Telemetry
    {
        public string host { get; set; }
        public int port { get; set; }
    }

    public class Timestamps
    {
        public DateTime? launched { get; set; }
        public DateTime? deployed { get; set; }
        public DateTime? failed { get; set; }
        public DateTime? cancelled { get; set; }
    }

}
