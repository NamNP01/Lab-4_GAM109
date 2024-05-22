using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string Name;
    public string ID;
    public int Age;
    public Student(string _Name, string _ID, int _Age)
    {
        Name = _Name;
        ID = _ID;
        Age = _Age;
    }
}
internal class Program
{
    
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student("Nam", "1", 20));
        students.Add(new Student("Linh", "2", 21));
        students.Add(new Student("huyen", "3", 15));
        students.Add(new Student("bai", "4", 19));
        students.Add(new Student("dai", "5", 25));


        var CauA = from Stu in students
                   where Stu.Age > 12 && Stu.Age < 20
                   select Stu;
        Console.WriteLine(" LINQ Query Syntax");
        foreach( var student in CauA)
        {
            Console.WriteLine(" "+student.Name +" " +student.ID+" "+student.Age);
        }


        var CauB = students.Where(Stu => Stu.Age > 12 && Stu.Age < 20);
        Console.WriteLine(" LINQ Method Syntax ");
        foreach (var student in CauB)
        {
            Console.WriteLine(" " + student.Name + " " + student.ID + " " + student.Age);
        }
    }
}
