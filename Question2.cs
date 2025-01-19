using System;

class Question2
{
    static void Main(string[] args)
    {
        Console.WriteLine("first number:");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("second number:");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int sum = n1 + n2;
        Console.WriteLine("The sum is: " + sum);
    }
}
