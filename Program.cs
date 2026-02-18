using TaskManagerPro;

var tasks = new List<ITask>
{
    new SimpleTask("Buy groceries"),
    new SimpleTask("Email professor"),
    new TimedTask("Study algorithms", 45),
    new ReccuringTask("Check email", "Weekly")
};

foreach (var task in tasks)
{
    task.Display();
}

tasks[0].Complete();

Console.WriteLine("\nAfter completeing first task:\n");

foreach (var task in tasks)
{
    task.Display();
}

