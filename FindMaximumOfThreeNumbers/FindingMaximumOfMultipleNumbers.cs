using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumOfThreeNumbers
{
    internal class FindingMaximumOfMultipleNumbers<T> where T : IComparable<T>
    {
        private List<T> elements;

        public FindingMaximumOfMultipleNumbers(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }

        public T MaximumOfMultiple()
        {
            T max = FindMaximum(elements.ToArray());
            PrintMax(max);
            return max;
        }

        public static T FindMaximum(params T[] elements)
        {
            List<T> sortedElements = elements.ToList();
            sortedElements.Sort();

            return sortedElements.Last();
        }
        private void PrintMax(T max)
        {
            Console.WriteLine("The maximum value is: " + max);
        }
    }
}

 
