using System.Drawing;
using System.Collections.Generic;
using System;
public class Rectangle : Parallelogram {

	public Rectangle(){

	}

	~Rectangle(){

	}

	public override void draw(Graphics graphics)
    {
        Point[] vertexes = this.getVertexes().ToArray();
        if(vertexes.Length == 2)
        {
            int width = Math.Abs(vertexes[1].X - vertexes[0].X);
            int height = Math.Abs(vertexes[0].Y - vertexes[1].Y);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(vertexes[0], 
                new Size(width, height));
            graphics.DrawRectangle(this.BorderPen, rect);
            graphics.FillRectangle(this.FillPen.Brush, rect);
        }
    }

    public override bool tapOnCreate(Point vertex)
    {
        if (this.getVertexes().Count == 0)
            this.Center = vertex;
        return base.tapOnCreate(vertex) || this.getVertexes().Count==2;
    }

    public override List<Point> Location(){

		return this.getVertexes();
	}
}//end Rectangle