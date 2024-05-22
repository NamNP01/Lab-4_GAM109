using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{

    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5,7,8 };
        var newList = list.FindAll(item => item % 2 != 0);
        Console.Write("cac so le la");
        foreach(var item in newList)
        {
            Console.Write( " " +item);
        }
    }
}
