using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Estructure_basic.negocio
{
    public class Mesa: Objeto
    {
        public double width { get; set; }
        public double height { get; set; }
        public double depth { get; set; }

        [JsonConstructor]
        public Mesa(double width, double height, double depth, double centerX, double centerY, double centerZ) : base (centerX, centerY, centerZ)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;

            this.parts.Add("mesa", new Parte(width, height * 0.2, depth, centerX, centerY, depth, 1, 0, 0));
            this.parts.Add("pata1", new Parte(width*0.1, height, depth, centerX - (width*0.4), centerY - (height*0.6), depth, 1, 1, 0));
            this.parts.Add("pata2", new Parte(width*0.1, height, depth, centerX + (width*0.4), centerY - (height*0.6), depth, 1, 1, 0));
        }
    }
}
