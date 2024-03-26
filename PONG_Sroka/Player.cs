using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace PONG_Sroka
{
    public class Player : ICanvasObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Canvas Canvas { get; set; }
        public Rectangle Shape { get; set; }
        public bool MousePlayer { get; set; }
        public int Points { get; set; }
        
    }
}
