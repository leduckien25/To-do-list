namespace TodoList
{
    class TaskManager : ItaskManager
    {
        private readonly List<TaskItem> tasks = new();
        public void AddTask()
        {
            Console.Write("Enter task description: ");
            string description = Console.ReadLine()!;
            tasks.Add(new TaskItem(description));
            Console.WriteLine("Task added successfully!");
        }
        public void ViewTasks()
        {

            if (!tasks.Any())
            {
                Console.WriteLine("No tasks available.");
                return;
            }
            
            Console.Clear();
            Console.WriteLine("--- Your To-Do List ---");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"No.{i + 1}: {tasks[i].Description}, status: {(tasks[i].IsCompleted ? "[v]" : "[ ]")}");
            }

            Console.WriteLine("0. Exit");
            while (true)
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0) break;
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            
        }
        public void MarkTask()
        {
            Console.Write("Enter task index: ");
            if (int.TryParse(Console.ReadLine(), out int markIndex))
            {
                markIndex--;
                if (markIndex < 0 || markIndex >= tasks.Count)
                {
                    Console.WriteLine("Invalid task index.");
                    return;
                }

                MarkTaskByIndex(markIndex);

                Console.WriteLine("Task marked as completed!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        public void MarkTaskByIndex(int markIndex)
        {
            tasks[markIndex].IsCompleted = true;
        }
        public void DeleteTask()
        {
            Console.Write("Enter index: ");
            if (int.TryParse(Console.ReadLine(), out int deleteIndex))
            {
                deleteIndex--;
                if (deleteIndex < 0 || deleteIndex >= tasks.Count)
                {
                    Console.WriteLine("Invalid task index.");
                    return;
                }
                DeleteTaskByIndex(deleteIndex);
                Console.WriteLine("Task deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        public void DeleteTaskByIndex(int deleteIndex)
        {
            tasks.RemoveAt(deleteIndex);
        }
        public void UpdateTask()
        {
            Console.Write("Enter index and new description: ");
            string[] input = Console.ReadLine()!.Split(' ');

            if (input.Length == 2 && int.TryParse(input[0], out int updateIndex))
            {
                updateIndex--;
                if (updateIndex < 0 || updateIndex >= tasks.Count)
                {
                    Console.WriteLine("Invalid task index.");
                    return;
                }
                UpdateTaskByIndex(updateIndex, input[1]);
                Console.WriteLine("Task updated successfully!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        public void UpdateTaskByIndex(int updateIndex, string newDescription)
        {
            tasks[updateIndex].Description = newDescription;
        }
        public void SaveTasks()
        {
            using (StreamWriter writer = new("tasks.txt"))
            {
                foreach (var task in tasks)
                {
                    writer.WriteLine($"{task.Description}|{task.IsCompleted}");
                }
            }
        }
        public void LoadTasks()
        {
            if (!File.Exists("tasks.txt"))
                return;

            tasks.Clear();

            using (StreamReader reader = new("tasks.txt"))
            {
                string line;
                while ((line = reader.ReadLine()!) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        tasks.Add(new(parts[0]) { IsCompleted = bool.Parse(parts[1]) });
                    }
                }
            }
        }
    }
}
