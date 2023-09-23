using System.Diagnostics;
namespace aot_benchmark.debug;

public static class DTiming
{
    private static TimeSpan _period;
    private static readonly TimeSpan[] ThreadsCount;

    static DTiming()
    {
        _period = new TimeSpan();
        ThreadsCount = new TimeSpan[Process.GetCurrentProcess().Threads.Count];
    }

    public static void Start()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        for (int i = 0; i < ThreadsCount.Length; i++)
            ThreadsCount[i] = Process.GetCurrentProcess().Threads[i].UserProcessorTime;
    }

    public static void Stop()
    {
        for (int i = 0; i < ThreadsCount.Length; i++)
        {
            var tSpan = Process.GetCurrentProcess().Threads[i].UserProcessorTime.Subtract(ThreadsCount[i]);
            if (tSpan > TimeSpan.Zero) _period = tSpan;
        }
    }

    public static TimeSpan Result()
    {
        return _period;
    }
}