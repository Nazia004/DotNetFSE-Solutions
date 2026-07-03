namespace TaskManagement
{
    public class Task
    {
        public int TaskId { get; set; }

        public string TaskName { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public Task(int taskId, string taskName, string status)
        {
            TaskId = taskId;
            TaskName = taskName;
            Status = status;
        }

        public override string ToString()
        {
            return $"ID: {TaskId}, Task: {TaskName}, Status: {Status}";
        }
    }
}