using System;
using System.Collections.Generic;
using System.Drawing;

namespace Paint.Shapes
{
    class TriangleShape : Shape
    {
        public TriangleShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
               base(currentStartPoint, currentEndPoint, normalFillColor)
        {
        }

        public override void Show(Graphics g)
        {
            if (startPoint == endPoint) return;

            Point[] points = new Point[3];
            points[0] = startPoint;
            points[1] = new Point(endPoint.X, startPoint.Y);
            points[2] = new Point((startPoint.X + endPoint.X) / 2, endPoint.Y);

            g.FillPolygon(new SolidBrush(_fillColor), points);
            g.DrawPolygon(_pen, points);
        }

        public override Shape Clone()
        {
            return new TriangleShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}
