using CleanBO7.Application.TodoLists.Queries.ExportTodos;

namespace CleanBO7.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
