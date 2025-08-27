namespace Ex1b
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
            for(int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    Console.Write(a[i] +  " ");
                }
            }
        }
    }
}
