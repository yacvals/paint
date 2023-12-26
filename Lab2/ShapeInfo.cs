using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ShapeInfo
    {
            private Point _startPoint;
            private Point _endPoint;
            private string _shapeName;
            public ShapeInfo(Point startPoint, Point endPoint, string shapeName)
            {
                _startPoint = startPoint;
                _endPoint = endPoint;
                _shapeName = shapeName;
            }

            public Point StartPoint
            {
                get { return _startPoint; }
                set { _startPoint = value; }
            }

            public Point EndPoint
            {
                get { return _endPoint; }
                set { _endPoint = value; }
            }

            public string ShapeName
            {
                get { return _shapeName; }
                set { _shapeName = value; }
            }

        }
    }
