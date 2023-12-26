using Paint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class RectangleShape : Shape
    {
        int width;
        int height;
        public RectangleShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
                         base(currentStartPoint, currentEndPoint, normalFillColor)
        { }
        public override void Show(Graphics g)
        {
            width = Math.Abs(endPoint.X - startPoint.X);
            height = Math.Abs(endPoint.Y - startPoint.Y);
            g.FillRectangle(new SolidBrush(_fillColor),
            Math.Min(startPoint.X, endPoint.X),
                            Math.Min(startPoint.Y, endPoint.Y),
                            width,
            height);

            g.DrawRectangle(_pen,
                            Math.Min(startPoint.X, endPoint.X),
                            Math.Min(startPoint.Y, endPoint.Y),
                            width,
                            height);
        }

        public override Shape Clone()
        {
            return new RectangleShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}
