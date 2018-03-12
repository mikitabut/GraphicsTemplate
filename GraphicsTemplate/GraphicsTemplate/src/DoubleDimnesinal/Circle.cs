using System;
using System.Collections.Generic;
using System.Drawing;

public class Circle : Ellipse {

	public Circle(){

	}

    public override void draw(Graphics formGraphics)
    {
        int difX = Math.Abs(this.getCenter().X - this.Point.X);
        int difY = Math.Abs(this.getCenter().Y - this.Point.Y);
        int radius = (int)Math.Sqrt(difX * difX + difY * difY);
        formGraphics.DrawEllipse(
            this.BorderPen,
            new RectangleF(
                this.getCenter().X - radius,
                this.getCenter().Y - radius,
                2 * radius, 2 * radius
            )
        );
        formGraphics.FillEllipse(
            this.FillPen.Brush,
            new RectangleF(
                this.getCenter().X - radius,
                this.getCenter().Y - radius,
                2 * radius, 2 * radius
            )
        );
    }

    /// 
    /// <param name="destination"></param>
    public void Move(Point destination) { }

}//end Circle
