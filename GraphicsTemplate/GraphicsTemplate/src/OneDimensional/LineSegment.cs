using System.Drawing;
using System.Collections.Generic;
using System;
public class LineSegment : Ray {

	public LineSegment(){

	}

	public override void draw(Graphics graphics) {
        graphics.DrawLine(this.BorderPen, this.getCenter(), this.GetSecondPoint());
    }

}//end LineSegment
