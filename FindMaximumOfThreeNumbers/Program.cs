namespace FindMaximumOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose what program u want");
            Console.WriteLine("1.finding max number using integer datatype\n2.finding maximum using float datatype\n3.finding maximum using string datatype");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 3:
                    Console.WriteLine("Maximum of three fruits is " + FindMaxUsingStringDatatype("Apple", "Peach", "Banana"));
                    Console.WriteLine("Maximum of three fruits is " + FindMaxUsingStringDatatype("Peach", "Apple", "Banana"));
                    Console.WriteLine("Maximum of three fruits is " + FindMaxUsingStringDatatype("Apple", "Peach", "Banana"));
                    Console.WriteLine("Maximum  of three fruits is " + FindMaxUsingStringDatatype("Banana", "Apple", "Peach"));
                    break;
                case 2:
                    Console.WriteLine("enter the first number");
                    float m = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("enter the second number");
                    float n = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("enter the third number");
                    float o = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("maximum number compare to three  is  " + (FindMaxNumbersUsingFloatDatatype(m, n, o)));
                    Console.WriteLine("enter the first number ie,.max value compare to another two numbers");
                    float p = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("enter the second number");
                    float q = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("enter the third number");
                    float r = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("maximum number compare to three is  " + (FindMaxNumbersUsingFloatDatatype(p, q, r)));
                    Console.WriteLine("enter the first number");
                    float s = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("enter the second number ie max value compare to another two  numbers");
                    float t = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("enter the third number");
                    float u = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("maximum number compare to three is " + (FindMaxNumbersUsingFloatDatatype(s, t, u)));
                    Console.WriteLine("enter the first number");
                    float v = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("enter the second number");
                    float w = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("enter the third number ie compare to another two numbers enter max value");
                    float x = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("maximum number compare to three is  " + (FindMaxNumbersUsingFloatDatatype(v, w, x)));
                    break;
                case 1:
                    Console.WriteLine("enter the first number");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the second number");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the third number");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("maximum number compare to three  is  " + (FindMaxNumber(a, b, c)));
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
                    break;










            }
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
        public static float FindMaxNumbersUsingFloatDatatype(float firstNum, float secondNum, float thirdNum)
        {
            float max = firstNum;

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
        public static string FindMaxUsingStringDatatype(string fruit1, string fruit2, string fruit3)
        {
            string max = fruit1;

            if (fruit2.CompareTo(max) > 0)
            {
                max = fruit2;
            }

            if (fruit3.CompareTo(max) > 0)
            {
                max = fruit3;
            }

            return max;
        }
    }
    
}