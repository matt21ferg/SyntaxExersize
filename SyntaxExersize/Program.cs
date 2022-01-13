using System;

namespace SyntaxExersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? "is less than 9" : "is more than 9";
            Console.WriteLine($"{answer} {response}");

            
        
        }   
    }
}
