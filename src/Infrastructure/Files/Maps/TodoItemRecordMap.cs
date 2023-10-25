using System.Globalization;
using CleanBO7.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace CleanBO7.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
