//*Func < T, TResult > Func là một delegate generic trong C
//# được sử dụng để định nghĩa một phương thức có thể trả về một giá trị.
//*/
//* Func chấp nhận đến 16 tham số đầu vào và trả về một giá trị TResult.
///*Predicate<T> Predicate là một delegate trong C # được sử dụng để kiểm tra điều kiện của một đối tượng.
//* Predicate chấp nhận một tham số T và trả về một giá trị boolean.
//*/
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Lambda Expression để tỉnh bình phương của một số
        Func<int, int> square = x => x* x;
        int result = square(5);
        Console.WriteLine("Bình phương của 5 là:" + result);
        // Lambda Expression để kiểm tra số chắn 
        Predicate<int> isEven = x => x % 2 == 0;
        Console.WriteLine("6 có phải là số chắn không?" + isEven(6));
        // Lambda Expression để in ra các phần tử trong danh sách  
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Console.Write("Các số trong danh sách: ");


        numbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine();


        // Lambda Expression để tim tổng các số chia hết cho 3 trong danh sách
        var sumDivisibleBy3 = numbers.Where (num => num % 3==0).Sum();
        Console.WriteLine("Tổng các số chia hết cho 3 là: " + sumDivisibleBy3);
    }
}