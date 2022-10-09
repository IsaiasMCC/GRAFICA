using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Estructure_basic.negocio
{
    public class Casa : Objeto
    {
        public double width { get; set; }
        public double height { get; set; }
        public double depth { get; set; }

        [JsonConstructor]
        public Casa(double width, double height, double depth, double centerX, double centerY, double centerZ) : base(centerX, centerY, centerZ)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;

            this.parts.Add("tejado", new Parte(width, height * 0.3, depth, centerX, centerY + (height * 0.3) + height*0.1, centerZ/2, 0f, 1f, 1f));
            this.parts.Add("cuerpo", new Parte(width, height/2, depth, centerX, centerY, centerZ/2, 0f, 1f, 0f));
            this.parts.Add("puerta", new Parte(width*0.15, height*0.3, depth*0.01, centerX, centerY -(height*0.3)/3 , centerZ*0.01, 1f, 0.5f, 0f));
            this.parts.Add("ventana1", new Parte(width*0.15, height*0.3/2, depth*0.01, centerX - (width/2)*0.7, centerY + (height * 0.1), centerZ*0.01, 1f, 1f, 0f));
            this.parts.Add("ventana2", new Parte(width * 0.15, height * 0.3 / 2, depth * 0.01, centerX + (width / 2) * 0.7, centerY + (height * 0.1), centerZ * 0.01, 1f, 1f, 0f));
        }
    }
}
