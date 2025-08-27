namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            string[] input = Console.ReadLine()!.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] a = new int[n];
  
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(input[i]);
            }
            int max_value = a[0], min_value = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max_value) max_value = a[i];
                if (a[i] < min_value) min_value = a[i];
            }
            Console.WriteLine("Max element in array is : " + max_value);
            Console.WriteLine("Min element in array is : " + min_value);
        }
    }
}
