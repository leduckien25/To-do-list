namespace TodoList
{
    class ToDoListApp
    {
        static void Main()
        {
            TaskManager taskManager = new();
            ConsoleUI consoleUI = new(taskManager);
            consoleUI.ShowMenu();
        }

    }

}