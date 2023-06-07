using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumOfThreeNumbers
{
    internal class MaximumOfMultipleNumbers<T>where T : IComparable<T>
    {
        private List<T> elements;

        public MaximumOfMultipleNumbers(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }

        public T MaximumOfMultiple()
        {
            return FindMaximum(elements.ToArray());
        }

        public static T FindMaximum(params T[] elements)
        {
            List<T> sortedElements = elements.ToList();
            sortedElements.Sort();

            return sortedElements.Last();
        }
    }
}
