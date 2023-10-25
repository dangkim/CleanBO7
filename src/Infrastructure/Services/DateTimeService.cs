using CleanBO7.Application.Common.Interfaces;

namespace CleanBO7.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
