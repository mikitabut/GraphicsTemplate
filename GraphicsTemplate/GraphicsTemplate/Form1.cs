using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsTemplate
{
    public partial class Form1 : Form
    {
        private enum CurrentDrawing
        {
            Line,
            Ray,
            LineSegment,
            Ellipse,
            Circle,
            Poligon,
            RegularPoligon,
            Parallelogram,
            Rectangle,
            Rhomb,
            IsoscelesTriangle,
            RightTriangle
        }

        private CurrentDrawing drawing = CurrentDrawing.Line;
        bool DrawingEnabled = false;

        Shape shape;

        Color currentBorderColor = Color.Red;
        Color currentFillColor = Color.Red;
        Point linePoint1;
        List<Shape> shapes = new List<Shape>();
        Graphics formGraphics;

        public Form1()
        {
            InitializeComponent();
            this.shape = new Line();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.formGraphics = this.panel1.CreateGraphics();
        }

        private void Reload()
        {
            foreach (var shape in shapes)
            {
                shape.draw(this.formGraphics);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.formGraphics.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawing = CurrentDrawing.Line;
            this.createCurrentShape();
        }

        private void createCurrentShape()
        {
            switch (drawing)
            {
                case CurrentDrawing.Ellipse:
                    Ellipse ellipse = new Ellipse();
                    ellipse.setFillColor(this.currentFillColor);
                    ellipse.setBorderColor(this.currentBorderColor);
                    this.shape = ellipse;
                    break;
                case CurrentDrawing.Circle:
                    Circle circle = new Circle();
                    circle.setFillColor(this.currentFillColor);
                    circle.setBorderColor(this.currentBorderColor);
                    this.shape = circle;
                    break;
                case CurrentDrawing.Line:
                    Shape line = new Line();
                    line.setBorderColor(this.currentBorderColor);
                    this.shape = line;
                    break;
                case CurrentDrawing.Ray:
                    Shape ray = new Ray();
                    ray.setBorderColor(this.currentBorderColor);
                    this.shape = ray;
                    break;
                case CurrentDrawing.LineSegment:
                    Shape lineSegment = new LineSegment();
                    lineSegment.setBorderColor(this.currentBorderColor);
                    this.shape = lineSegment;
                    break;
                //case CurrentDrawing.Poligon:
                //    Shape poligon = new Poligon();
                //    poligon.setBorderColor(this.currentBorderColor);
                //    this.shape = poligon;
                //    break;
            }
        }

        private void FalseAll()
        {
            DrawingEnabled = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.FalseAll();
                this.formGraphics.Clear(Color.White);
                this.Reload();
                return;
            }

            this.createCurrentShape();
            DrawingEnabled = true;
            linePoint1 = e.Location;
            this.shape.move(e.Location);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (DrawingEnabled)
            {
                this.shape.dragOnCreate(linePoint1, e.Location);
                this.formGraphics.Clear(Color.White);
                this.Reload();
                this.shape.draw(this.formGraphics);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (DrawingEnabled)
            {
                this.shapes.Add(this.shape);
                this.shape = null;
                this.DrawingEnabled = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.currentBorderColor = this.colorDialog1.Color;
                this.createCurrentShape();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {

                this.currentFillColor = this.colorDialog1.Color;
                this.createCurrentShape();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawing = CurrentDrawing.Ellipse;
            this.createCurrentShape();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drawing = CurrentDrawing.Ray;
            this.createCurrentShape();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            drawing = CurrentDrawing.LineSegment;
            this.createCurrentShape();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            drawing = CurrentDrawing.Poligon;
            this.createCurrentShape();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            drawing = CurrentDrawing.Circle;
            this.createCurrentShape();
        }
    }
}
