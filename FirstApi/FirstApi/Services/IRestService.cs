using System;
using System.Collections.Generic;
using System.Text;
using FirstApi.Model;
using System.Threading.Tasks;

namespace FirstApi.Services
{
    public interface IRestService
    {
        Task<List<TodoItemModel>> GetTodoItemAsync();
        Task SaveTodoItemAsync(TodoItemModel item, bool isNewItem);
        Task DeleteTodoItemAsync(TodoItemModel item);
    }
}
