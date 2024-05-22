using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserData
{
    public string Name;
    public int Level;
    public UserData(string _Name, int _Level)
    {
        Name = _Name;
        Level = _Level;
    }
}
internal class Program
{
    
    static void Main(string[] args)
    {
        List<UserData> list = new List<UserData>();
        list.Add(new UserData("GTA5", 10));
        list.Add(new UserData("Gensin", 15));
        list.Add(new UserData("Gunny", 5));
        list.Add(new UserData("LOL", 100));
        Console.WriteLine("in ra");
        var select = list.Select(u => new { u.Name, u.Level });
        foreach (var item in select)
        {
            Console.WriteLine("Name:" + item.Name +" | level:" +item.Level);
        }

        Console.WriteLine("Giam dan");
        var numbers = list.OrderByDescending(D => D.Level);
        foreach(var item in numbers)
        {
            Console.WriteLine("Name:" + item.Name + " | level:" + item.Level);
        }
    }
}
