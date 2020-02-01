using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var gcd = GeneralizedGCD(5, new[] {  24,500,4, 6, 8, 10,12, 59 });
            Console.WriteLine($"GCD is: {gcd}");
            Console.ReadLine();
        }    
        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public static int GeneralizedGCD(int num, int[] arr)
        {
            int gcd = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                gcd = GetGcd(arr[i], gcd);
            }

            return gcd;
        }
        // METHOD SIGNATURE ENDS    // check for gcd
        static int GetGcd(int x, int y)
        {
            if (x == 0)
                return y;
            return GetGcd(y % x, x);
        }
    }
}
