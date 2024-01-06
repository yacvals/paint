using System;
using System.Drawing;

namespace Paint.Shapes
{
    class DiamondShape : Shape
    {
        public DiamondShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
            base(currentStartPoint, currentEndPoint, normalFillColor)
        {
        }

        public override void Show(Graphics g)
        {
            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);

            Point[] diamondPoints = new Point[4];

            diamondPoints[0] = new Point(startPoint.X + width / 2, startPoint.Y);
            diamondPoints[1] = new Point(endPoint.X, startPoint.Y + height / 2);
            diamondPoints[2] = new Point(startPoint.X + width / 2, endPoint.Y);
            diamondPoints[3] = new Point(startPoint.X, startPoint.Y + height / 2);

            g.FillPolygon(new SolidBrush(_fillColor), diamondPoints);
            g.DrawPolygon(_pen, diamondPoints);
        }

        public override Shape Clone()
        {
            return new DiamondShape(this.startPoint, this.endPoint, this._fillColor);
        }
    }
}
