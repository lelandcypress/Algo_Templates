using System;

class SelectionSort
{

    static void sort(int[] arr)
    {

        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min_indx = i;
            for (int j = i + 1; j < n - 1; j++)
            {
                if (arr[j] < arr[i])
                {
                    min_indx = j;
                }
                int temp = arr[min_indx];
                arr[min_indx] = arr[i];
                arr[i] = temp;
            }
        }

    }

    static void printNewArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        int[] arr = { 25, 11, 98, 3, 16 };
        sort(arr);
        Console.WriteLine("Output:");
        printNewArray(arr);
    }

}//EOC
