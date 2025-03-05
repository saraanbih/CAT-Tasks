using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    static int FindMaxElement(int[] arr)
    {
        int max = arr[0];
        foreach (int item in arr) if (item > max) max = item;

        return max;
    }
    static bool IsVowel(char c)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        foreach (char item in vowels) if (item == char.ToLower(c)) return true;
        return false;
        //another Better way
        //HashSet<char> set = new HashSet<char> { 'a', 'e', 'o', 'i', 'u' };
        //return set.Contains(c);
    }
    static void MultiplicationTable(int n)
    {
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{n} * {i} = {n * i}");
        }
    }
    static bool CanDividedBy3And4(int n)
    {
        return n % 3 == 0 && n % 4 == 0;
    }

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

    static int FindSecondLargetElement(int[] arr)
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
    static void Main()
    {
        //1 Program
        int[] arr1 = new int[10];
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write($"Please Enther the element {i + 1} : ");
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = FindMaxElement(arr1);
        Console.WriteLine($"The Maximum Element in the array is {max}");

        ///////////////////////////////////////////////////////////////////
        //2 Problem
        Console.Write("Please Enter a character to check if it's vowel or not");
        char ch = char.Parse(Console.ReadLine());
        Console.WriteLine((IsVowel(ch) ? "vowel" : "consonant"));

        ///////////////////////////////////////////////////////////////////
        //3 Problem
        Console.Write("Please Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        MultiplicationTable(number);

        ///////////////////////////////////////////////////////////////////
        //4 Problem
        Console.Write("Please Enter a Number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(CanDividedBy3And4(num) ? "Yes" : "No");

        ///////////////////////////////////////////////////////////////////
        //5 Problem
        Console.Write("Please Enter a decimal number: ");
        decimal number1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine(ConvertToBinary(number1));

        ////////////////////////////////////////////////////////////////////
        //6 Problem
        int[] array1 = { 1, 3, 5, 7, 9 };
        int[] array2 = { 2, 4, 6, 8, 10 };

        int[] res = MergeSorted2Arrays(array1, array2);

        Console.WriteLine("Merged and Sorted Array:");
        Console.WriteLine(string.Join(" ", res));

        ////////////////////////////////////////////////////////////////////
        //7 Problem
        int[] arr = { 10, 20, 4, 45, 99, 99, 50 };

        int secondLargest = FindSecondLargetElement(arr);
        if (secondLargest == int.MinValue)
            Console.WriteLine("No second largest element found.");
        else
            Console.WriteLine("Second Largest Element: " + secondLargest);

        /////////////////////////////////////////////////////////////////////
        //8 Problem
        int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] res1 = ReverseArray(arr2);
        foreach (var item in res1)
            Console.Write(item + " ");
    }


}
