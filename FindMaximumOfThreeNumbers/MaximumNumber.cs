using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumOfThreeNumbers
{
    internal class MaximumNumber<T> where T : IComparable<T>
    {
        
            private T a;
            private T b;
            private T c;

            public MaximumNumber(T a, T b, T c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public T MaximumOfThree()
            {
                return FindMaximum(a, b, c);
            }

            public static T FindMaximum(T a, T b, T c)
            {
                T max = a;

                if (b.CompareTo(max) > 0)
                {
                    max = b;
                }

                if (c.CompareTo(max) > 0)
                {
                    max = c;
                }

                return max;
            }
        

    }
}
