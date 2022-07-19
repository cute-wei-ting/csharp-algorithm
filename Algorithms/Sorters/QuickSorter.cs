using Algorithms.Common;

namespace Algorithms.Sorters
{
    //  unstable
    //  internal, in-place,
    //  time complexity average: O(n log(n)),
    //  time complexity worst: O(n^2),
    //  space complexity: O(log(n)), stack 使用
    public static class QuickSorter
    {
        public static void QuickSort<T>(this IList<T> collection,IComparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            collection.InternalQuickSort(0, collection.Count - 1,comparer);
        }

        public static void InternalQuickSort<T>(this IList<T> collection,int firstIndex, int lastIndex, IComparer<T> comparer)
        {
            if (firstIndex >= lastIndex) return;

            int p = collection.Partition(firstIndex, lastIndex, comparer);
            collection.InternalQuickSort(firstIndex,p-1, comparer);
            collection.InternalQuickSort(p+1, lastIndex, comparer);
        }

        public static int Partition<T>(this IList<T> collection,int firstIndex,int lastIndex, IComparer<T> comparer)
        {
            T pivotValue = collection[lastIndex];
            int pivotIndex = lastIndex;

            int wallIndex = firstIndex;

            for (int i = firstIndex; i <= lastIndex - 1; i++)
            {
                if (comparer.Compare(collection[i],pivotValue)<=0)
                {
                    collection.Swap(wallIndex,i);
                    wallIndex++;
                }
            }
            collection.Swap(wallIndex, pivotIndex);
            return wallIndex;
        }


    }

}