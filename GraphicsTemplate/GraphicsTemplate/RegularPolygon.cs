public class RegularPolygon : Poligon {

	private int count;

	public RegularPolygon(){

	}

	~RegularPolygon(){

	}

	public override void Dispose(){

	}

	public abstract override void draw();

	public int getCount(){

		return 0;
	}

	public override vector<Point> location(){

		return null;
	}

	/// 
	/// <param name="destination"></param>
	public abstract override void move(Point destination);

	/// 
	/// <param name="newVal"></param>
	public void setCount(int newVal){

	}

}//end RegularPolygon
