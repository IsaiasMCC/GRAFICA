using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructure_basic.negocio;
namespace Estructure_basic
{
    static class Program
    {
 
        [STAThread]
        static void Main()
        {
            Game game = new Game(800, 600, "Estructura Basica");
        }
    }
}
