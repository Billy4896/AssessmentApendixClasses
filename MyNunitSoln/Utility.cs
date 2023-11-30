using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNunitSoln
{
    public class Utility
    {
        // Part 3
        /// <summary>
        /// Performs a lineaer search in ascending order to find the target object inside the array.
        /// </summary>
        /// <typeparam name="T">The type of objects in the array.</typeparam>
        /// <param name="array">The sorted array to search.</param>
        /// <param name="target">The target object to find in the array.</param>
        /// <returns>True if the target is found; else false.</returns>
        public static bool LinearSeachOfObjectAsc<T>(T[] array, T target) where T : IComparable<T> {
            try
            {
                int i = 0;
                bool found = false;
                while (!found && i < array.Length)
                {
                    if (target.Equals(array[i]))
                        found = true;
                    else
                        i++;
                }
                if (i < array.Length)
                    return true;
                else
                    return false;
            }
            catch(Exception e)
            {
                Console.WriteLine($"An error has occurred during the LinearSearchOfObjectAsc: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Sorts an array of objects in ascending order using the Bubble sort algorithm.
        /// </summary>
        /// <typeparam name="T">The type of objects in the array.</typeparam>
        /// <param name="array">The sorted array to search.</param>
        public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            try {
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        {
                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine($"An error has occurred during the BubbleSort: {e.Message}");
                throw;
            }

        }

        /// <summary>
        /// Sorts an array of objects in Descending order using the Bubble sort algorithm.
        /// </summary>
        /// <typeparam name="T">The type of objects in the array.</typeparam>
        /// <param name="array">The sorted array to search.</param>
        public static void BubbleSortDescending<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) < 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


        // Part 4
        /// <summary>
        /// Performs a binary search to find the index of the specified target in a sorted array.
        /// </summary>
        /// <typeparam name="T">The type of objects in the array.</typeparam>
        /// <param name="array">The sorted array to search.</param>
        /// <param name="target">The target object to find in the array.</param>
        /// <returns>If found, the index of the target; else -1.</returns>
        public static int BinarySearch<T>(T[] array, T target) where T : IComparable<T>
        {
            try
            {
                int min = 0;
                int max = array.Length - 1;

                while (min <= max)
                {
                    int mid = (min + max) / 2;
                    int comparisonResult = target.CompareTo(array[mid]);

                    if (comparisonResult == 0)
                    {
                        return mid; // Element found
                    }
                    else if (comparisonResult < 0)
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }

                return -1; // Element not found
            } 
            catch (Exception e) 
            {
                Console.WriteLine($"An error has occurred during the BinarySearch: {e.Message}");
                throw;
            }
        }


        /// <summary>
        /// Performs a sequential search to find the index of the specified target in an array.
        /// </summary>
        /// <typeparam name="T">The type of objects in the array.</typeparam>
        /// <param name="array">The sorted array to search.</param>
        /// <param name="target">If found, the index of the target; else -1.</param>
        /// <returns>If found, the index of the target; else -1.</returns>
        public static int SequentialSearch<T>(T[] array, T target) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (target.CompareTo(array[i]) == 0)
                {
                    return i; // Element found
                }
            }

            return -1; // Element not found
        }




    }
}
