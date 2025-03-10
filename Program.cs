using System;
using System.Text;

class Program
{
    #region Find Maximum Element in Array
    static int FindMaxElement(int[] arr)
    {
        int max = arr[0];
        foreach (int item in arr) if (item > max) max = item;
        return max;
    }
    #endregion

    #region Check if Character is Vowel
    static bool IsVowel(char c)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        return Array.Exists(vowels, v => v == char.ToLower(c));
    }
    #endregion

    #region Print Multiplication Table
    static void MultiplicationTable(int n)
    {
        for (int i = 1; i <= 12; i++)
            Console.WriteLine($"{n} * {i} = {n * i}");
    }
    #endregion

    #region Check if Number is Divisible by 3 and 4
    static bool CanDividedBy3And4(int n)
    {
        return n % 3 == 0 && n % 4 == 0;
    }
    #endregion

    #region Convert Decimal to Binary
    static string ConvertToBinary(decimal number)
    {
        string res = "";
        while (number > 0)
        {
            res = (number % 2) + res;
            number = Math.Floor(number / 2);
        }
        return res;
    }
    #endregion

    #region Merge Two Sorted Arrays
    static int[] MergeSorted2Arrays(int[] arr1, int[] arr2)
    {
        int[] res = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j]) res[k++] = arr1[i++];
            else res[k++] = arr2[j++];
        }
        while (i < arr1.Length) res[k++] = arr1[i++];
        while (j < arr2.Length) res[k++] = arr2[j++];
        return res;
    }
    #endregion

    #region Find Second Largest Element
    static int FindSecondLargestElement(int[] arr)
    {
        int mx = arr[0], sec_max = int.MinValue;
        foreach (var item in arr)
        {
            if (item > mx)
            {
                sec_max = mx;
                mx = item;
            }
            else if (item > sec_max && item != mx) sec_max = item;
        }
        return sec_max;
    }
    #endregion

    #region Reverse an Array
    static int[] ReverseArray(int[] arr)
    {
        int i = 0, j = arr.Length - 1;
        while (i < j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            i++;
            j--;
        }
        return arr;
    }
    #endregion

    #region Main Method
    static void Main()
    {
        // 1. Find Maximum Element
        int[] arr1 = new int[10];
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write($"Please Enter the element {i + 1}: ");
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"The Maximum Element in the array is {FindMaxElement(arr1)}");

        // 2. Check Vowel or Consonant
        Console.Write("Please Enter a character to check if it's a vowel or not: ");
        char ch = char.Parse(Console.ReadLine());
        Console.WriteLine(IsVowel(ch) ? "Vowel" : "Consonant");

        // 3. Print Multiplication Table
        Console.Write("Please Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        MultiplicationTable(number);

        // 4. Check if Number is Divisible by 3 and 4
        Console.Write("Please Enter a Number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(CanDividedBy3And4(num) ? "Yes" : "No");

        // 5. Convert Decimal to Binary
        Console.Write("Please Enter a decimal number: ");
        decimal number1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine(ConvertToBinary(number1));

        // 6. Merge Two Sorted Arrays
        int[] array1 = { 1, 3, 5, 7, 9 };
        int[] array2 = { 2, 4, 6, 8, 10 };
        int[] mergedArray = MergeSorted2Arrays(array1, array2);
        Console.WriteLine("Merged and Sorted Array: " + string.Join(" ", mergedArray));

        // 7. Find Second Largest Element
        int[] arr = { 10, 20, 4, 45, 99, 99, 50 };
        int secondLargest = FindSecondLargestElement(arr);
        Console.WriteLine(secondLargest == int.MinValue ? "No second largest element found." : "Second Largest Element: " + secondLargest);

        // 8. Reverse Array
        int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] reversedArray = ReverseArray(arr2);
        Console.WriteLine("Reversed Array: " + string.Join(" ", reversedArray));
    }
    #endregion
}
