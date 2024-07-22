using System;

namespace BTTL
{
    internal class MergeSort
    {

        public static void Main(string[] args)
        {
            int[] array = { 12, 11, 13, 5, 6, 7 };
            MergeSort ms = new MergeSort();
            Console.WriteLine("Mang cho truoc:");
            PrintArray(array);

            ms.Sort(array, 0, array.Length - 1);

            Console.WriteLine("\nMang da sap xep :");
            PrintArray(array);
        }


        public void Sort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(A, left, mid);
                Sort(A, mid + 1, right);
                Merge(A, left, mid, right);
            }
        }


        private void Merge(int[] A, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] LeftArray = new int[n1];
            int[] RightArray = new int[n2];


            for (int idx = 0; idx < n1; idx++)
                LeftArray[idx] = A[left + idx];
            for (int jdx = 0; jdx < n2; jdx++)
                RightArray[jdx] = A[mid + 1 + jdx];

            int k = left, i = 0, j = 0;


            while (i < n1 && j < n2)
            {
                if (LeftArray[i] <= RightArray[j])
                {
                    A[k] = LeftArray[i];
                    i++;
                }
                else
                {
                    A[k] = RightArray[j];
                    j++;
                }
                k++;
            }


            while (i < n1)
            {
                A[k] = LeftArray[i];
                i++;
                k++;
            }


            while (j < n2)
            {
                A[k] = RightArray[j];
                j++;
                k++;
            }
        }


        private static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
