using System.Diagnostics;
namespace aot_benchmark;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10000];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 1000);
        }
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Sort(array);
        stopWatch.Stop();
        Console.WriteLine(stopWatch.Elapsed);
        
    }
    
    private static void Sort(int[] i)
    {
        int n = i.Length;
        for (int a = 1; a < n; a++)
        for (int j = n - 1; j >= a; j--)
            if (i[j - 1] > i[j])
                (i[j - 1], i[j]) = (i[j], i[j - 1]);
    }
}