namespace ThreadingLesson;

class TaskExample
{
    public static async Task Run()
    {
        Task t1 = Task.Run(() => DoWork("Task 1"));
        Task t2 = Task.Run(() => DoWork("Task 2"));
        Task t3 = Task.Run(() => DoWork("Task 3"));
        Task t4 = Task.Run(() => DoWork("Task 4"));
        Task t5 = Task.Run(() => DoWork("Task 5"));

        await Task.WhenAll(t1, t2, t3, t4, t5);
        Console.WriteLine("All tasks completed.");
    }

    static void DoWork(string name)
    {
        for (int i = 0; i < int.MaxValue; i++)
        {
            Console.WriteLine($"thread: {name} - value: {i}");
            //Thread.Sleep(500);
        }
    }
}