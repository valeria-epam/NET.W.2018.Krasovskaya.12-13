using System;
using System.Collections.Generic;

namespace BinarySearchTask
{
    public static class BinarySearch
    {
        /// <summary>
        /// Searches the <paramref name="item"/> in the <paramref name="array"/>.
        /// </summary>
        /// <param name="array">Sorted array.</param>
        /// <param name="item">Item in the <paramref name="array"/> which position is searched.</param>
        public static int Search<T>(this T[] array, T item)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            return Search(array, item, 0, array.Length - 1, Comparer<T>.Default);
        }

        /// <summary>
        /// Searches the <paramref name="item"/> in the <paramref name="array"/>.
        /// </summary>
        /// <param name="array">Sorted array.</param>
        /// <param name="item">Item in the <paramref name="array"/> which position is searched.</param>
        /// <param name="comparer">The comparer used to compare array elements.</param>
        public static int Search<T>(this T[] array, T item, IComparer<T> comparer)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            return Search(array, item, 0, array.Length - 1, comparer);
        }

        private static int Search<T>(T[] array, T item, int firstIndex, int lastIndex, IComparer<T> comparer)
        {
            while (lastIndex >= firstIndex)
            {
                int middle = ((lastIndex - firstIndex) / 2) + firstIndex;
                int c = comparer.Compare(array[middle], item);
                if (c < 0)
                {
                    firstIndex = middle + 1;
                }
                else if (c > 0)
                {
                    lastIndex = middle - 1;
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }
    }
}
