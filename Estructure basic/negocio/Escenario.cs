using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Estructure_basic.negocio
{
    class Escenario : IObjeto
    {
        public double centerX { get; set; }
        public double centerY { get; set; }
        public double centerZ { get; set; }

        public Dictionary<string, Objeto> objectList { get; set; }

        [JsonConstructor]
        public Escenario(double centerX, double centerY, double centerZ)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.centerZ = centerZ;
            this.objectList = new Dictionary<string, Objeto>();
        }

        public void add(string key, Objeto value)
        {
            this.objectList.Add(key, value);
        }

        public void Dibujar()
        {
            foreach (KeyValuePair<string, Objeto> objeto in this.objectList)
            {
                objeto.Value.Dibujar();
            }
        }

        public Objeto get(string key)
        {
            Objeto value = null;
            foreach(KeyValuePair<string, Objeto> obj in this.objectList)
            {
                if (key == obj.Key)
                    value = obj.Value;
            }
            return value;
        }
    }
}
