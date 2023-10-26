using System.Globalization;
using CleanBO7.Application.Common.Interfaces;
using CleanBO7.Application.TodoLists.Queries.ExportTodos;
using CleanBO7.Infrastructure.Files.Maps;
using CsvHelper;

namespace CleanBO7.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildProductsFile(IEnumerable<ProductRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<ProductRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
