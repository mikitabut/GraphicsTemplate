public class RightTriangle : Poligon {

	private Point vertex;

	public RightTriangle(){

	}

	~RightTriangle(){

	}

	public override void Dispose(){

	}

	public abstract override void draw();

	public Point getVertex(){

		return null;
	}

	public override vector<Point> location(){

		return null;
	}

	/// 
	/// <param name="destination"></param>
	public abstract override void move(Point destination);

	/// 
	/// <param name="newVal"></param>
	public void setVertex(Point newVal){

	}

}//end RightTriangle
