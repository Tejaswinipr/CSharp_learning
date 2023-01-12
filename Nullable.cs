using System;
namespace learning
{
	public class Nullable
	{
	public static void Main(string[] args)
		{
			string? s = null;
			int? a = null;
			int? b = a ?? 20;
			Console.WriteLine(b);
		}
	}
}

