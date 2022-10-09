using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Estructure_basic.negocio
{
    public class Auto : Objeto
    {   
        public double width { get; set; }
        public double height { get; set; }
        public double depth { get; set; }

        [JsonConstructor]
        public Auto( double width, double height, double depth, double centerX, double centerY, double centerZ) : base (centerX, centerY, centerZ)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;

            this.parts.Add("cuerpo", new Parte(width, height/2, depth, centerX, centerY - (height / 2)/2, centerZ, 1, 1, 0));
            this.parts.Add("techo", new Parte(width * 0.7, height / 2, depth,centerX, centerY + (height / 2) / 2, centerZ, 1, 1, 0));
            this.parts.Add("rueda1", new Parte(width/7, height/3, depth, centerX - (width/4), centerY - (height/2), centerZ, 0, 1, 0));
            this.parts.Add("rueda2", new Parte(width / 7, height / 3, depth, centerX + (width / 4), centerY - (height / 2), centerZ, 0, 1, 0));
        }
    }
}
