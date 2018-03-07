public class Rectangle : Parallelogram {

	public Rectangle(){

	}

	~Rectangle(){

	}

	public override void Dispose(){

	}

	public abstract override void draw();

	public override vector<Point> location(){

		return null;
	}

	/// 
	/// <param name="destination"></param>
	public abstract override void move(Point destination);

}//end Rectangle
