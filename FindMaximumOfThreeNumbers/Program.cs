namespace FindMaximumOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maximum number compare to three  is  "  + (FindMaxNumber(a,b,c)));
            Console.WriteLine("enter the first number ie,.max value compare to another two numbers");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maximum number compare to three is  " + (FindMaxNumber(d, e, f)));
            Console.WriteLine("enter the first number");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number ie max value compare to another two  numbers");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maximum number compare to three is " + (FindMaxNumber(g, h, i)));
            Console.WriteLine("enter the first number");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number ie compare to another two numbers enter max value");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maximum number compare to three is  " + (FindMaxNumber(j, k, l)));
        }

        public static int FindMaxNumber(int firstNum, int secondNum, int thirdNum)
        {
            int max = firstNum;

            if (secondNum.CompareTo(max) > 0)
            {
                max = secondNum;
            }

            if (thirdNum.CompareTo(max) > 0)
            {
                max = thirdNum;
            }

            return max;
        }
    }
    
}