using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Estructure_basic.extras
{
    public class Point
    {   
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        [JsonConstructor]
        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
