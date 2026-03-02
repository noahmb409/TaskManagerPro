namespace TaskManagerPro.Core.Abstract;
using TaskManagerPro.Core.Interfaces;
using TaskManagerPro.Core.Models;


public static class BaseTaskFP{

    public static ITaskFP Complete(ITaskFP task) =>
        task switch
        {
            SimpleTaskFP s => s with {IsCompleted = true},
            TimedTaskFP t => t with {IsCompleted = true},
            RecurringTaskFP r => r with {IsCompleted = true},
            _ => task 
        };
}