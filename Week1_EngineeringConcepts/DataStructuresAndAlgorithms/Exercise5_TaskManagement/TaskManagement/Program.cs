namespace TaskManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskLinkedList tasks = new TaskLinkedList();

            tasks.AddTask(new Task(1, "Prepare Report", "Pending"));
            tasks.AddTask(new Task(2, "Attend Meeting", "Completed"));
            tasks.AddTask(new Task(3, "Code Review", "In Progress"));

            tasks.DisplayTasks();

            tasks.SearchTask(2);

            tasks.DeleteTask(2);

            tasks.DisplayTasks();
        }
    }
}
