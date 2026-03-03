namespace TaskManagerPro.Core.Models;
using TaskManagerPro.Core.Abstract;

public class RecurringTask : BaseTask
{
    public string Recurrences {get; private set; }

    public RecurringTask(string title, string recurrences) : base(title)
    {
        Recurrences = recurrences;
    }

    public override void Complete()
    {
        Console.WriteLine($"{Title} completed once,but it recurs");
    }

    public override void Display()
    {
        Console.WriteLine($"[Recurred] {Title} ({Recurrences}) - Completed: {IsCompleted}");
    }
}