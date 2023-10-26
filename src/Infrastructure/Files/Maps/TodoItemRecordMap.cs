using System.Globalization;
using CleanBO7.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace CleanBO7.Infrastructure.Files.Maps;

public class ProductRecordMap : ClassMap<ProductRecord>
{
    public ProductRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
