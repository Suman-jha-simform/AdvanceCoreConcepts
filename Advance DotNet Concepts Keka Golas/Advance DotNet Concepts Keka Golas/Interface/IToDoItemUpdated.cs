using Advance_DotNet_Concepts_Keka_Goals.Models;

namespace Advance_DotNet_Concepts_Keka_Goals.Interface
{
    public interface IToDoItemUpdated
    {
        Task<IEnumerable<ToDoItemUpdated>> GetToDoItemsAsync();
        Task<ToDoItemUpdated> GetToDoItemAsync(int id);
        Task<int> AddToDoItem(ToDoItemUpdated item);
        Task<int> UpdateToDoItem(int id, ToDoItemUpdated item);
        Task<int> DeleteToDoItemAsync(int id);
    }
}
