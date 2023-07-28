using System;
class Program
{
    static void Main(string[] args)
    {
        int[] oddArray = new int[] { 1, 3, 5 };
        int i = 0;
        while (i < oddArray.Length)
        {
            Console.WriteLine(oddArray[i]);
            i++;
        }
        Console.ReadKey();
    }
}
