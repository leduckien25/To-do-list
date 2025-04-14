namespace TodoList
{
    class ConsoleUI
    {
        private readonly ItaskManager taskManager;
        private bool isRunning = true;
        public ConsoleUI(ItaskManager taskManager)
        {
            this.taskManager = taskManager;
        }
        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("\n--- TO-DO LIST MENU ---");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task as Completed");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Update Task");
            Console.WriteLine("6. Save");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");
        }
        public void ShowMenu()
        {
            taskManager.LoadTasks();

            while (isRunning)
            {
                DisplayMenu();
                string choice = Console.ReadLine()!;
                ProcessChoice(choice);
            }
        }
        private void ProcessChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    taskManager.AddTask();
                    break;

                case "2":
                    taskManager.ViewTasks();
                    break;

                case "3":
                    taskManager.MarkTask();
                    break;

                case "4":
                    taskManager.DeleteTask();
                    break;

                case "5":
                    taskManager.UpdateTask();
                    break;

                case "6":
                    taskManager.SaveTasks();
                    Console.WriteLine("Tasks saved.");
                    break;

                case "7":
                    Console.WriteLine("Exiting program...");
                    isRunning = false;
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;

            }
        }
    }
}
