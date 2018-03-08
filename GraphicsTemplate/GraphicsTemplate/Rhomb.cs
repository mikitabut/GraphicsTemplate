public class Rhomb : Parallelogram {

	public Rhomb(){

	}

	~Rhomb(){

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

}//end Rhomb
