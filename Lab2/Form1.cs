using Lab2;
using Paint.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paint
{
    public partial class MainForm : Form
    {
        private TableForm tableForm;
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            MyEditor.GetInstance().OnLBdown(e.Location);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            MyEditor.GetInstance().OnMouseMove(e.Location);
            if (e.Button == MouseButtons.Left)
            {
                Refresh();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            Table.GetInstance().AddShapeInfo(MyEditor.GetInstance().currentShape.startPoint, e.Location, MyEditor.GetInstance().currentShape.ukr_name);
            MyEditor.GetInstance().OnLBup(e.Location);
            Refresh();
        }

        private void Point_Click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new PointShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);
        }
        private void iconPoint_Click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new PointShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);
        }

        private void Line_Click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new LineShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new RectangleShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new EllipseShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);
        }

        private void LineOO_Click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new LineOOShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);
        }

        private void Cube_Click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new CubeShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MyEditor.GetInstance().OnPaint(g);
        }

        private void ToolStripMenuClose_Click(object sender, EventArgs e)
        {
            if (tableForm != null)
            {
                tableForm.Close();
            }
        }

        private void ToolStripMenuOpen_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm();
            this.tableForm = tableForm;
            tableForm.Show(this);
        }

        private void ToolStripMenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Data to Text File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Table.GetInstance().SaveDataToTextFile(filePath);
            }
        }

        private void LineOO_click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new LineOOShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);

        }

        private void Cube_click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new CubeShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);

        }

        private void iconLine_Click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new LineShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);
        }

        private void iconRect_Click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new RectangleShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);

        }

        private void iconEllipse_Click(object sender, EventArgs e)
        {
            MyEditor.GetInstance().currentShape = new EllipseShape(System.Drawing.Point.Empty, System.Drawing.Point.Empty, Color.Empty);
        }
    }

}