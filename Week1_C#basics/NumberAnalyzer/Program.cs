using System;

class Program {
    static void Main() {
        Console.WriteLine("Enter a number");

        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;

        switch(number % 2)
        {
            case 0:
                Console.WriteLine("The number is even");
                break;
            case 1:
            case -1:
                Console.WriteLine("The number is odd");
                break;
        }  

        for (int i=1; i<=number; i++) if((number % i) == 0) count++;
        if (count == 2)  Console.WriteLine("The number is a prime number");

        if (number > 0) Console.WriteLine("The number is positive");
        else if (number < 0) Console.WriteLine("The number is negative");
        else Console.WriteLine("The number is 0");

        int sq = number * number;
        Console.WriteLine("The square of the number is: " + sq);

        double sqrt= Math.Sqrt(number);

        if (number >= 0) 
        Console.WriteLine("The square root of the number is: " + sqrt);
        else
        Console.WriteLine("The square root is not defined for negative numbers");

        
    }
}


