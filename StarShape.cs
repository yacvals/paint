using System;
using System.Collections.Generic;
using System.Drawing;

namespace Paint.Shapes
{
    class StarShape : Shape
    {
        List<Shape> starParts = new List<Shape>();

        public StarShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
               base(currentStartPoint, currentEndPoint, normalFillColor)
        {
        }

        private void CreateSubShapes()
        {
            starParts.Clear();

            if (startPoint == endPoint) return;

            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);

            Point[] starPoints = GetStarPoints(startPoint.X + width / 2, startPoint.Y + height / 2, 5, width / 2, height / 2);

            for (int i = 0; i < starPoints.Length - 1; i++)
            {
                LineShape starLine = new LineShape(starPoints[i], starPoints[i + 1], _normalFillColor);
                starParts.Add(starLine);
            }

            // Connect the last and the first points to close the star
            LineShape closingLine = new LineShape(starPoints[starPoints.Length - 1], starPoints[0], _normalFillColor);
            starParts.Add(closingLine);
        }

        private Point[] GetStarPoints(int x, int y, int arms, int outerRadius, int innerRadius)
        {
            double angle = Math.PI / arms;
            Point[] starPoints = new Point[2 * arms];

            for (int i = 0; i < 2 * arms; i++)
            {
                int radius = i % 2 == 0 ? outerRadius : innerRadius;
                starPoints[i] = new Point(
                    x + (int)(Math.Cos(i * angle) * radius),
                    y + (int)(Math.Sin(i * angle) * radius)
                );
            }

            return starPoints;
        }

        public override void Show(Graphics g)
        {
            CreateSubShapes();

            foreach (Shape shape in starParts)
            {
                shape.Show(g);
            }
        }

        public override Shape Clone()
        {
            return new StarShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}
