using System.Collections.Generic;
using System.Drawing;
using System;
public class Rhomb : Parallelogram {

	public Rhomb(){

	}

	~Rhomb(){

	}

	public override void draw(Graphics graphics)
    {
        Point[] taps = this.getVertexes().ToArray();
        if (taps.Length == 3)
        {
            int deltaX = 0, deltaY = 0;
            List<Point> vertexes = new List<Point>();
            deltaX = Math.Abs(taps[0].X - taps[1].X);
            deltaY = Math.Abs(taps[0].Y - taps[2].Y);
            vertexes.Add(new Point(taps[0].X, taps[0].Y + deltaY));
            vertexes.Add(new Point(taps[0].X + deltaX, taps[0].Y));
            vertexes.Add(new Point(taps[0].X, taps[0].Y - deltaY));
            vertexes.Add(new Point(taps[0].X - deltaX, taps[0].Y));
            this.vertexNumber = 4;
            this.setVertexes(vertexes);
            graphics.DrawPolygon(this.BorderPen, vertexes.ToArray());
            graphics.FillPolygon(this.FillPen.Brush, vertexes.ToArray());
        }
        else if(taps.Length == 4)
        {
            graphics.DrawPolygon(this.BorderPen, taps);
            graphics.FillPolygon(this.FillPen.Brush, taps);
        }
    }

	public override List<Point> Location(){

		return null;
	}

	/// 
	/// <param name="destination"></param>
	public override void move(Point destination) { }

}//end Rhomb