using System;
namespace learning
{
	public class Delegates
	{
		public delegate void squareDel(double side);

		public void area(double side)
		{
			Console.WriteLine("Area: {0}",(side*side));
		}
		public void perimeter(double side)
		{
			Console.WriteLine("Perimeter: {0}",(4*side));
		}
		public static void Main(String[] args) {
			Delegates sq = new Delegates();
			squareDel sqDel = new squareDel(sq.area);
			sqDel += sq.perimeter;
			sqDel.Invoke(5);
			Console.WriteLine();

		}

	}

}

