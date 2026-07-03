using System;

namespace TaskManagement
{
    public class TaskLinkedList
    {
        private Node? head;

        // Add Task
        public void AddTask(Task task)
        {
            Node newNode = new Node(task);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        // Display Tasks
        public void DisplayTasks()
        {
            Console.WriteLine("\nTask List:");

            Node? current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        // Search Task
        public void SearchTask(int taskId)
        {
            Node? current = head;

            while (current != null)
            {
                if (current.Data.TaskId == taskId)
                {
                    Console.WriteLine("\nTask Found:");
                    Console.WriteLine(current.Data);
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("\nTask not found.");
        }

        // Delete Task
        public void DeleteTask(int taskId)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data.TaskId == taskId)
            {
                head = head.Next;
                Console.WriteLine("\nTask deleted.");
                return;
            }

            Node current = head;

            while (current.Next != null &&
                   current.Next.Data.TaskId != taskId)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                Console.WriteLine("\nTask deleted.");
            }
            else
            {
                Console.WriteLine("\nTask not found.");
            }
        }
    }
}