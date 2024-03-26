using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PONG_Sroka
{
    public class Ball : ICanvasObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Canvas Canvas { get; set; }
        public double Angle { get; set; }
        public int DirectionX { get; set; }
        public int DirectionY { get; set; }
        public double Speed { get; set; }
        public Ellipse Shape { get; set; }

        
    }
}
