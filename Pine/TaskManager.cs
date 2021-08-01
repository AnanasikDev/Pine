using System;
using System.Collections.Generic;
namespace Pine
{
    public static class TaskManager
    {
        public static readonly List<Task> Tasks = new List<Task>();
        
        public static Task GenerateNewTask(string title)
        {
            Task newTask = new Task(title, new Vector2(40, (Tasks.Count + 1) * 40), false);
            Tasks.Add(newTask);

            return newTask;
        }
    }
}
