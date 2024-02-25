using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dPoint
{
    internal class BoundaryBL
    {
        public PointBL TopLeft;
        public PointBL TopRight;
        public PointBL BottomLeft;
        public PointBL BottomRight;

        public BoundaryBL()
        {
            TopLeft = new PointBL(0,0);
            TopRight = new PointBL(0,90);
            BottomLeft = new PointBL(90, 0);
            BottomRight = new PointBL(90, 90);
        }

        public BoundaryBL(PointBL topLeft, PointBL topRight, PointBL bottomLeft, PointBL bottomRight)
        {
            TopLeft = topLeft;
            TopRight = topRight;
            BottomLeft = bottomLeft;
            BottomRight = bottomRight;
        }
    }
}
