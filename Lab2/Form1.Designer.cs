namespace Paint
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            File = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            Objects = new ToolStripMenuItem();
            Point = new ToolStripMenuItem();
            Line = new ToolStripMenuItem();
            Rectangle = new ToolStripMenuItem();
            Ellipse = new ToolStripMenuItem();
            кубToolStripMenuItem = new ToolStripMenuItem();
            гантеліToolStripMenuItem = new ToolStripMenuItem();
            довідкаToolStripMenuItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            iconPoint = new ToolStripButton();
            iconLine = new ToolStripButton();
            iconRect = new ToolStripButton();
            iconEllipse = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { File, Objects, довідкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { зберегтиToolStripMenuItem });
            File.Name = "File";
            File.Size = new Size(48, 20);
            File.Text = "Файл";
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(119, 22);
            зберегтиToolStripMenuItem.Text = "Закрити";
            зберегтиToolStripMenuItem.Click += ToolStripMenuClose_Click;
            // 
            // Objects
            // 
            Objects.DropDownItems.AddRange(new ToolStripItem[] { Point, Line, Rectangle, Ellipse, кубToolStripMenuItem, гантеліToolStripMenuItem });
            Objects.Name = "Objects";
            Objects.Size = new Size(62, 20);
            Objects.Text = "Об'єкти";
            // 
            // Point
            // 
            Point.Name = "Point";
            Point.Size = new Size(149, 22);
            Point.Text = "Крапка";
            Point.Click += Point_Click;
            // 
            // Line
            // 
            Line.Name = "Line";
            Line.Size = new Size(149, 22);
            Line.Text = "Лінія";
            Line.Click += Line_Click;
            // 
            // Rectangle
            // 
            Rectangle.Name = "Rectangle";
            Rectangle.Size = new Size(149, 22);
            Rectangle.Text = "Прямокутник";
            Rectangle.Click += Rectangle_Click;
            // 
            // Ellipse
            // 
            Ellipse.Name = "Ellipse";
            Ellipse.Size = new Size(149, 22);
            Ellipse.Text = "Еліпс";
            Ellipse.Click += Ellipse_Click;
            // 
            // кубToolStripMenuItem
            // 
            кубToolStripMenuItem.Name = "кубToolStripMenuItem";
            кубToolStripMenuItem.Size = new Size(149, 22);
            кубToolStripMenuItem.Text = "Куб";
            кубToolStripMenuItem.Click += Cube_click;
            // 
            // гантеліToolStripMenuItem
            // 
            гантеліToolStripMenuItem.Name = "гантеліToolStripMenuItem";
            гантеліToolStripMenuItem.Size = new Size(149, 22);
            гантеліToolStripMenuItem.Text = "Гантелі";
            гантеліToolStripMenuItem.Click += LineOO_click;
            // 
            // довідкаToolStripMenuItem
            // 
            довідкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відкритиToolStripMenuItem, зберегтиToolStripMenuItem1 });
            довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            довідкаToolStripMenuItem.Size = new Size(65, 20);
            довідкаToolStripMenuItem.Text = "Таблиця";
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.Size = new Size(124, 22);
            відкритиToolStripMenuItem.Text = "Відкрити";
            відкритиToolStripMenuItem.Click += ToolStripMenuOpen_Click;
            // 
            // зберегтиToolStripMenuItem1
            // 
            зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            зберегтиToolStripMenuItem1.Size = new Size(124, 22);
            зберегтиToolStripMenuItem1.Text = "Зберегти";
            зберегтиToolStripMenuItem1.Click += ToolStripMenuSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 398);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += MainForm_Paint;
            pictureBox1.MouseDown += MainForm_MouseDown;
            pictureBox1.MouseMove += MainForm_MouseMove;
            pictureBox1.MouseUp += MainForm_MouseUp;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { iconPoint, iconLine, iconRect, iconEllipse, toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // iconPoint
            // 
            iconPoint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconPoint.Image = (Image)resources.GetObject("iconPoint.Image");
            iconPoint.ImageTransparentColor = Color.Magenta;
            iconPoint.Name = "iconPoint";
            iconPoint.Size = new Size(23, 22);
            iconPoint.Text = "Point";
            iconPoint.Click += iconPoint_Click;
            // 
            // iconLine
            // 
            iconLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconLine.Image = (Image)resources.GetObject("iconLine.Image");
            iconLine.ImageTransparentColor = Color.Magenta;
            iconLine.Name = "iconLine";
            iconLine.Size = new Size(23, 22);
            iconLine.Text = "Line";
            iconLine.Click += iconLine_Click;
            // 
            // iconRect
            // 
            iconRect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconRect.Image = (Image)resources.GetObject("iconRect.Image");
            iconRect.ImageTransparentColor = Color.Magenta;
            iconRect.Name = "iconRect";
            iconRect.Size = new Size(23, 22);
            iconRect.Text = "Rectangle";
            iconRect.Click += iconRect_Click;
            // 
            // iconEllipse
            // 
            iconEllipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconEllipse.Image = (Image)resources.GetObject("iconEllipse.Image");
            iconEllipse.ImageTransparentColor = Color.Magenta;
            iconEllipse.Name = "iconEllipse";
            iconEllipse.Size = new Size(23, 22);
            iconEllipse.Text = "Ellipse";
            iconEllipse.Click += iconEllipse_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "куб";
            toolStripButton1.Click += Cube_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += LineOO_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem File;
        private ToolStripMenuItem Objects;
        private ToolStripMenuItem Point;
        private ToolStripMenuItem Line;
        private ToolStripMenuItem Rectangle;
        private ToolStripMenuItem Ellipse;
        private PictureBox pictureBox1;
        private ToolStripMenuItem довідкаToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton iconPoint;
        private ToolStripButton iconLine;
        private ToolStripButton iconRect;
        private ToolStripButton iconEllipse;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem кубToolStripMenuItem;
        private ToolStripMenuItem гантеліToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem1;
    }
}