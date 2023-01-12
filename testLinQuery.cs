
using System.Linq;
using System;
using System.Collections.Generic;

class testLinQuery
{
    public static void Main(string[] args)
    {

        int[] scores = { 97, 92, 81, 60 };
        IEnumerable<int> scoreQuery = from score in scores where score > 80 orderby score ascending select score;
        foreach (int i in scoreQuery)
        {
            Console.WriteLine(i + " ");
        }
    }

}
