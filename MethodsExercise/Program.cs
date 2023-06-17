using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static void Main(string[] args)
        {// -----------------Exercise 1---------------------------
            Console.WriteLine("Hello, What is your name?");
             var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("what is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("what is your favorite band?");
            var band = Console.ReadLine();

            // -----------------Exercise 2---------------------------
            var cats = Sum(2, 4);
            Console.WriteLine($"There are {cats} cats in my house");

            var dogs = Multiply(10, 6);
            Console.WriteLine($"There are {dogs} dogs in the park");
        }
        
    }
}
