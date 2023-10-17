using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortAssist
{
    public class SelectionSort
    {
        public void Sort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    // Compare student names
                    if (string.Compare(arr[j], arr[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                // Swap the students
                string temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }
}
