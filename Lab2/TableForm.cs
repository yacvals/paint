using Lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
            Table.GetInstance().ShapeAdded += Table_ShapeAdded;
            DisplayShapeInTable();
        }

        private void Table_ShapeAdded(object sender, EventArgs e)
        {
            DisplayShapeInTable();
        }

        private void DisplayShapeInTable()
        {
            dataGridView1.Rows.Clear();

            foreach (ShapeInfo info in Table.GetInstance().GetShapeInfos())
            {
                dataGridView1.Rows.Add(info.ShapeName, info.StartPoint.X, info.StartPoint.Y, info.EndPoint.X, info.EndPoint.Y);
            }
        }

        private void TableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        /*public void SaveDataToTextFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        writer.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            writer.Write(dataGridView1.Rows[i].Cells[j].Value);
                            if (j < dataGridView1.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Дані успішно збережені.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}