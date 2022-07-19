using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorters
{
    //  stable
    //  time complexity worst: O(n log(n)) = T(n)=2T(n/2)+n by Master Theorem
    //  space complexity: O(n) = O(log(n)) + O(n) 合併的額外空間+call stack
    public static class MergeSorter
    {
        public static List<T> MergeSort<T>(this List<T> collection, IComparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            return InternalMergeSort(collection, comparer);
        }
        public static List<T> InternalMergeSort<T>(List<T> collection,IComparer<T> comparer)
        {
            int mid = collection.Count / 2;
            if (collection.Count < 2)
            {
                return collection;
            }
            var leftCollection = collection.GetRange(0, mid);
            var rightCollection = collection.GetRange(mid, collection.Count - mid);
            leftCollection = InternalMergeSort(leftCollection, comparer);
            rightCollection = InternalMergeSort(rightCollection, comparer);
            return Merge(leftCollection, rightCollection,comparer);
        }
        public static List<T> Merge<T>(List<T> left, List<T> right, IComparer<T> comparer)
        {
            List<T> result = new List<T>();
            int leftIndex = 0;
            int rightIndex = 0;

            while(leftIndex < left.Count && rightIndex < right.Count)
            {
                if (comparer.Compare(left[leftIndex], right[rightIndex]) <= 0)
                {
                    result.Add(left[leftIndex++]);
                }
                else
                {
                    result.Add(right[rightIndex++]);
                }
            }

            while (leftIndex != left.Count)
            {
                result.Add(left[leftIndex++]);
            }

            while (rightIndex != right.Count)
            {
                result.Add(right[rightIndex++]);
            }

            return result;
        }
    }

}