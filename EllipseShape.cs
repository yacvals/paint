using System;
using System.Drawing;
using System.Net;

namespace Lab5.Shapes
{
    class EllipseShape : Shape
    {
        int width;
        int height;
        public EllipseShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
                       base(currentStartPoint, currentEndPoint, normalFillColor)
        {
            ukr_name = "Еліпс";
        }
        public override void Show(Graphics g)
        {
            width = Math.Abs(endPoint.X - startPoint.X);
            height = Math.Abs(endPoint.Y - startPoint.Y);


            g.FillEllipse(new SolidBrush(_fillColor),
                            Math.Min(startPoint.X, endPoint.X),
                            Math.Min(startPoint.Y, endPoint.Y),
                            width,
                            height);
            g.DrawEllipse(_pen,
                            Math.Min(startPoint.X, endPoint.X),
                            Math.Min(startPoint.Y, endPoint.Y),
                            width,
                            height);
        }
        public override Shape Clone()
        {
            return new EllipseShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}