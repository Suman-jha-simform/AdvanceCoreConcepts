using Advance_DotNet_Concepts_Keka_Goals.Models;

namespace Advance_DotNet_Concepts_Keka_Goals.Interface
{
    public interface ITodoItem
    {
        Task<IEnumerable<ToDoItem>> GetToDoItemsAsync();
        Task<ToDoItem> GetToDoItemAsync(int id);
        Task<int> AddToDoItem(ToDoItem item);
        Task<int> UpdateToDoItem(int id, ToDoItem item);
        Task<int> DeleteToDoItemAsync(int id);
    }
}
