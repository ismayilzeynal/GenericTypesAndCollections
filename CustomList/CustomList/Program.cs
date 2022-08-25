using CustomList.Models;
using System;
using System.Collections.Generic;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> ml = new MyList<int>();
            ml.Add(5);
            ml.Add(3);
            ml.Add(7);
            ml.Add(48);
            ml.Remove(48);
            ml.Reverse();
            ml.IndexOf(5);
            ml.Add(3);
            ml.Exist(79);
            ml.LastIndexOf(3);
            ml.Clear();

        }
    }
    
}
