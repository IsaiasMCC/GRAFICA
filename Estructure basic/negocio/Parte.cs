using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using Estructure_basic.extras;
using System.Text.Json.Serialization;

namespace Estructure_basic.negocio
{
    public class Parte : IObjeto
    {   
        public double width { get; set; }
        public double height { get; set; }
        public double depth { get; set; }

        public double centerX { get; set; }
        public double centerY { get; set; }
        public double centerZ { get; set; }
        public float red { get; set; }
        public float green { get; set; }
        public float blue { get; set; }
        public List<Point> points { get; set; }

        [JsonConstructor]
        public Parte(double width, double height, double depth, double centerX, double centerY, double centerZ, float red, float green, float blue)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;

       
            this.centerX = centerX;
            this.centerY = centerY;
            this.centerZ = centerZ;

            this.red = red;
            this.green = green;
            this.blue = blue;
            points = new List<Point>();
        }
        public void Dibujar()
        {
            loadList();
            drawPolygon();
        }
        public void drawPolygon()
        {
            GL.Color3(this.red, this.green, this.blue);
            GL.Begin(PrimitiveType.Polygon);

            foreach(Point point in this.points){
                GL.Vertex3(point.x, point.y, point.z);
            }

            GL.End();
        }
        
        public void loadList()
        {
            this.points.Add( new Point(centerX - width / 2, centerY - height / 2, centerZ + depth) );
            this.points.Add( new Point(centerX - width / 2, centerY + height / 2, centerZ + depth) );
            this.points.Add( new Point(centerX + width / 2, centerY + height / 2, centerZ + depth) );
            this.points.Add( new Point(centerX + width / 2, centerY - height / 2, centerZ + depth) );
        }
        
    }
}
