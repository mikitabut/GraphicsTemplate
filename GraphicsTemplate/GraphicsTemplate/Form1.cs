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
        private bool lineDrawing;
        Line line;
        Point linePoint1;
        Point linePoint2;

        bool lineDrawingEnabled = false;
        List<Shape> shapes = new List<Shape>();
        Graphics formGraphics;

        public Form1()
        {
            InitializeComponent();
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
            this.lineDrawingEnabled = true;
        }

        private void FalseAll()
        {
            this.lineDrawing = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                this.FalseAll();
            }
            if (lineDrawingEnabled)
            {
                lineDrawing = true;
                linePoint1 = e.Location;
                line = new Line();
                line.setCenter(e.Location);
                line.setBorderColor(Color.Red);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (lineDrawing && lineDrawingEnabled)
            {
                this.line.SetSecondPoint(e.Location);
                this.formGraphics.Clear(Color.White);
                this.Reload();
                this.line.draw(this.formGraphics);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if(lineDrawing && lineDrawingEnabled)
            {
                this.shapes.Add(this.line);
                this.lineDrawing = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Reload();
        }
    }
}
