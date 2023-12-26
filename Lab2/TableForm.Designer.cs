namespace Paint
{
    partial class TableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ShapeName = new DataGridViewTextBoxColumn();
            x1 = new DataGridViewTextBoxColumn();
            y1 = new DataGridViewTextBoxColumn();
            x2 = new DataGridViewTextBoxColumn();
            y2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ShapeName, x1, y1, x2, y2 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(676, 338);
            dataGridView1.TabIndex = 0;
            // 
            // ShapeName
            // 
            ShapeName.HeaderText = "Фігура";
            ShapeName.MinimumWidth = 6;
            ShapeName.Name = "ShapeName";
            ShapeName.Width = 125;
            // 
            // x1
            // 
            x1.HeaderText = "x1";
            x1.MinimumWidth = 6;
            x1.Name = "x1";
            x1.Width = 125;
            // 
            // y1
            // 
            y1.HeaderText = "y1";
            y1.MinimumWidth = 6;
            y1.Name = "y1";
            y1.Width = 125;
            // 
            // x2
            // 
            x2.HeaderText = "x2";
            x2.MinimumWidth = 6;
            x2.Name = "x2";
            x2.Width = 125;
            // 
            // y2
            // 
            y2.HeaderText = "y2";
            y2.MinimumWidth = 6;
            y2.Name = "y2";
            y2.Width = 125;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 338);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TableForm";
            Text = "Таблиця";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ShapeName;
        private DataGridViewTextBoxColumn x1;
        private DataGridViewTextBoxColumn y1;
        private DataGridViewTextBoxColumn x2;
        private DataGridViewTextBoxColumn y2;
    }
}