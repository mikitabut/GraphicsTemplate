public class Parallelogram : Poligon {

	public class Triangle : Poligon {

		public Triangle(){

		}

		~Triangle(){

		}

		public override void Dispose(){

		}

		public override void draw(){

		}

		public override vector<Point> location(){

			return null;
		}

		/// 
		/// <param name="destination"></param>
		public override void move(Point destination){

		}

	}//end Triangle

	public Parallelogram(){

	}

	~Parallelogram(){

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

}//end Parallelogram
