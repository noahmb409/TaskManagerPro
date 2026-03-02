using TaskManagerPro;
using TaskManagerPro.Core.Models;
using TaskManagerPro.Core.Interfaces;
using TaskManagerPro.Core.Abstract;

System.Console.WriteLine("====================");
System.Console.WriteLine("Tasks using OOP\n");

var tasks = new List<ITask>
{
    new SimpleTask("Buy groceries"),
    new SimpleTask("Email professor"),
    new TimedTask("Study algorithms", 45),
    new RecurringTask("Check email", "Weekly")
};

foreach (var task in tasks)
{
    task.Display();
}

tasks[0].Complete();

System.Console.WriteLine("\n============================");
System.Console.WriteLine("Tasks after completeing first task:\n\n");

foreach (var task in tasks)
{
    task.Display();
}

