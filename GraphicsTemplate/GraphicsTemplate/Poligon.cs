public class Poligon : DoubleDimensional {

	private vector<Point> vertexes;

	public Poligon(){

	}

	~Poligon(){

	}

	public override void Dispose(){

	}

	public abstract override void draw();

	public vector<Point> getVertexes(){

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
	public void setVertexes(vector<Point> newVal){

	}

}//end Poligon
