namespace TodoList
{
    interface ItaskManager
    {
        void AddTask();
        void ViewTasks();
        void MarkTaskByIndex();
        void DeleteTaskByIndex();
        void UpdateTaskByIndex();
        void SaveTasks();
        void LoadTasks();
    }
}
