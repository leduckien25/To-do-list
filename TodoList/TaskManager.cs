namespace TodoList
{
<<<<<<< HEAD
    class TaskManager
    {
        private List<TaskItem> tasks = new();

        public void AddTask(string description)
        {
=======
    class TaskManager : ItaskManager
    {
        private readonly List<TaskItem> tasks = new();

        public void AddTask()
        {
            Console.Write("Enter task description: ");
            string description = Console.ReadLine();
>>>>>>> 236e4c7 (update TaskManager.cs and Program.cs, add ITaskManager.cs and ConsoleUI.cs)
            tasks.Add(new TaskItem(description));
            Console.WriteLine("Task added successfully!");
        }

<<<<<<< HEAD
        public void ViewTask()
=======
        public void ViewTasks()
>>>>>>> 236e4c7 (update TaskManager.cs and Program.cs, add ITaskManager.cs and ConsoleUI.cs)
        {
            if (!tasks.Any())
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("--- Your To-Do List ---");


            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"No.{i + 1}: {tasks[i].Description}, status: {(tasks[i].IsCompleted ? "[v]" : "[ ]")}");
            }
        }

<<<<<<< HEAD
        public void MarkTaskByIndex(int index)
        {
            index--;
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Invalid task index.");
                return;
            }

            tasks[index].IsCompleted = true;
            Console.WriteLine("Task marked as completed!");
        }

        public void DeleteTaskByIndex(int index)
        {
            index--;
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Invalid task index.");
                return;
            }

            tasks.RemoveAt(index);
            Console.WriteLine("Task deleted successfully!");
        }

        public void UpdateTaskByIndex(int index, string newDescription)
        {
            index--;
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Invalid task index.");
                return;
            }

            tasks[index].Description = newDescription;
            Console.WriteLine("Task updated successfully!");
=======
        public void MarkTaskByIndex()
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

                tasks[markIndex].IsCompleted = true;
                Console.WriteLine("Task marked as completed!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public void DeleteTaskByIndex()
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

                tasks.RemoveAt(deleteIndex);
                Console.WriteLine("Task deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public void UpdateTaskByIndex()
        {
            Console.Write("Enter index and new description: ");
            string[] input = Console.ReadLine().Split(' ');

            if (input.Length == 2 && int.TryParse(input[0], out int updateIndex))
            {
                updateIndex--;
                if (updateIndex < 0 || updateIndex >= tasks.Count)
                {
                    Console.WriteLine("Invalid task index.");
                    return;
                }
                tasks[updateIndex].Description = input[1];
                Console.WriteLine("Task updated successfully!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
>>>>>>> 236e4c7 (update TaskManager.cs and Program.cs, add ITaskManager.cs and ConsoleUI.cs)
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
                while ((line = reader.ReadLine()) != null)
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
