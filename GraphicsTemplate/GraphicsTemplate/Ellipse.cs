public class Ellipse : DoubleDimensional {

	private Point point;

	public Ellipse(){

	}

	~Ellipse(){

	}

	public override void Dispose(){

	}

	public abstract void draw();

	public Point GetPoint(){

		return null;
	}

	public abstract vector<Point> location();

	/// 
	/// <param name="destination"></param>
	public abstract void move(Point destination);

	/// 
	/// <param name="newVal"></param>
	public void SetPoint(Point newVal){

	}

}//end Ellipse
