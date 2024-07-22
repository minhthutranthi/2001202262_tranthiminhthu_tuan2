using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTTL
{
    internal class Binary_Search
    {
        public static int Search(int[] A, int n, int key)
        {
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (A[mid] == key)
                    return mid;
                if (key < A[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 5, 7, 9 };
            int n = A.Length;
            int key = 5;

            int result = Binary_Search.Search(A, n, key);
            Console.WriteLine(result);
        }
    }
}
