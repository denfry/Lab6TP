using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6TP
{
    internal abstract class Figure
    {
        
        protected internal int Width { get; set; }
        protected internal int Height { get; set; }
        protected internal int X { get; set; }
        protected internal int Y { get; set; }
        
        
        public abstract void Draw();
    }
}
