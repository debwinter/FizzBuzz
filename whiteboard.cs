using System;
using System.Text;

namespace FizzBuzz;
class Program
{
    static void Main(string[] args)
    {
        
    }

    public static string FizzBuzz(int n)
    {
        StringBuilder fb = new StringBuilder();
        if (n % 3 == 0) fb.Append("fizz");
        if (n % 5 == 0) fb.Append("buzz");
        return fb.ToString();
    }
}