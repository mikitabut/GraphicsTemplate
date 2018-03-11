using System.Drawing;
using System.Collections.Generic;
using System;
public class LineSegment : Ray {

	public LineSegment(){

	}

	public override void draw(Graphics graphics) {
        Pen pen = new Pen(this.getBorderColor());
        graphics.DrawLine(pen, this.getCenter(), this.GetSecondPoint());
        pen.Dispose();
    }

}//end LineSegment
