using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
        class Table
        {
            private static Table? instance;

            private List<ShapeInfo> shapeInfos = new List<ShapeInfo>();
            public event EventHandler ShapeAdded;
            public static Table GetInstance()
            {
                instance ??= new Table();
                return instance;
            }

            public void AddShapeInfo(Point start, Point end, string ukrName)
            {
                ShapeInfo newShapeInfo = new ShapeInfo(start, end, ukrName);
                shapeInfos.Add(newShapeInfo);

                OnShapeAdded();
            }

            public List<ShapeInfo> GetShapeInfos()
            {
                return shapeInfos;
            }

            protected void OnShapeAdded()
            {
                ShapeAdded?.Invoke(this, EventArgs.Empty);
            }

            public void SaveDataToTextFile(string filePath)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        writer.WriteLine("Назва, x1, y1, x2, y2");

                        foreach (var shapeInfo in shapeInfos)
                        {
                            writer.WriteLine($"{shapeInfo.ShapeName}, {shapeInfo.StartPoint.X}, {shapeInfo.StartPoint.Y}, {shapeInfo.EndPoint.X}, {shapeInfo.EndPoint.Y}");
                        }
                    }

                    MessageBox.Show("Дані успішно збережені.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

