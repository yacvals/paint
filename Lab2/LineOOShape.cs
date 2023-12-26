using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    class LineOOShape : Shape
    {
        List<Shape> lineOOParts = new List<Shape>();
        private int diameter = 20;

        public LineOOShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
                       base(currentStartPoint, currentEndPoint, normalFillColor)
        {
            ukr_name = "Відрізок";
        }

        private double GetVectorLength(Point vector)
        {
            return Math.Sqrt(
                vector.X * vector.X + vector.Y * vector.Y
            );
        }

        private void CreateSubShapes()
        {
            lineOOParts.Clear();
            if (startPoint == endPoint) return;

            Point vectorBetweenTwoPoints = new Point(
            endPoint.X - startPoint.X, endPoint.Y - startPoint.Y
            );

            double vectorBetweenTwoPointsLength = GetVectorLength(vectorBetweenTwoPoints);


            double unitVectorX = vectorBetweenTwoPoints.X / vectorBetweenTwoPointsLength;
            double unitVectorY = vectorBetweenTwoPoints.Y / vectorBetweenTwoPointsLength;


            Point centerToBorderVector = new Point(
                (int)Math.Round(unitVectorX * .5 * diameter), (int)Math.Round(unitVectorY * .5 * diameter)
            );


            Point lineStart = new Point(
                startPoint.X + centerToBorderVector.X,
                startPoint.Y + centerToBorderVector.Y
            );


            Point lineEnd = new Point(
                (int)Math.Round(lineStart.X + unitVectorX * (vectorBetweenTwoPointsLength - diameter)),
                (int)Math.Round(lineStart.Y + unitVectorY * (vectorBetweenTwoPointsLength - diameter))
            );

            Console.WriteLine(startPoint.ToString() + lineStart.ToString() + lineEnd.ToString());


            Point firstCircleStart = new Point(
                startPoint.X - diameter / 2,
                startPoint.Y - diameter / 2
            );

            Point firstCircleEnd = new Point(
                startPoint.X + diameter / 2,
                startPoint.Y + diameter / 2
            );

            Point secondCircleStart = new Point(
            endPoint.X - diameter / 2,
                endPoint.Y - diameter / 2
            );

            Point secondCircleEnd = new Point(
            endPoint.X + diameter / 2,
                endPoint.Y + diameter / 2
            );


            lineOOParts.Add(new EllipseShape(firstCircleStart, firstCircleEnd, _normalFillColor));
            lineOOParts.Add(new EllipseShape(secondCircleStart, secondCircleEnd, _normalFillColor));
            lineOOParts.Add(new LineShape(lineStart, lineEnd, _normalFillColor));
        }
        public override void Show(Graphics g)
        {
            CreateSubShapes();
            foreach (Shape shape in lineOOParts)
            {
                shape.Show(g);
            }
        }

        public override Shape Clone()
        {
            return new LineOOShape(this.startPoint, this.endPoint, this._normalFillColor);
        }

    }
}

