using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Estructure_basic.negocio
{
    public class Objeto : IObjeto
    {
        public double centerX { get; set; }
        public double centerY { get; set; }
        public double centerZ { get; set; }

        public Dictionary<string, Parte> parts { get; set; }

        [JsonConstructor]
        public Objeto(double centerX, double centerY, double centerZ)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.centerZ = centerZ;
            this.parts = new Dictionary<string, Parte>();
        }
        public void Dibujar()
        {
            foreach(KeyValuePair<string, Parte> part in this.parts)
            {
                part.Value.Dibujar();
            }

        }

  
    }
}
