using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasPoints.ViewModels
{
    public class MyEllipse
    {
        public int PointX { get; set; }
        public int PointY { get; set; }
        public MyEllipse(int PointX_, int PointY_)
        {
            PointX = PointX_;
            PointY = PointY_;
        }
    }
}
