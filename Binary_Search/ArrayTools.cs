using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    public class ArrayTools
    {
        public static void FillArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
        }


        public static int LinearSearchI(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int LinearSearchR(int[] arr, int key,int idx)
        {
            if (arr.Length == idx)
                return -1;
            if (arr[idx] == key)
                return key;
            return LinearSearchR(arr, key, idx + 1);
        }

        public static int BinarySearchR(int[] arr, int key, int start_idx, int end_idx)
        {
            int middle_idx = (start_idx + end_idx) / 2;
            if (arr[middle_idx] == key)
            {
                return middle_idx;
            }
            if (start_idx > end_idx)
            {
                return -1;
            }
            if (arr[middle_idx] > key)
            {
                return BinarySearchR(arr, key, start_idx, middle_idx - 1);
            }
            return BinarySearchR(arr, key, middle_idx + 1, end_idx);
        }

        public static int BinarySearchI(int[] arr, int key)
        {
            int start_idx = 0;
            int end_idx = arr.Length - 1;
            while (start_idx <= end_idx)
            {
                int middle_idx = (start_idx + end_idx) / 2;
                if (arr[middle_idx] == key)
                {
                    return key;
                }
                if (arr[middle_idx] < key)
                {
                    start_idx = middle_idx + 1;
                }
                else
                    end_idx = middle_idx - 1;
            }
            return -1;
        }
    }
}
