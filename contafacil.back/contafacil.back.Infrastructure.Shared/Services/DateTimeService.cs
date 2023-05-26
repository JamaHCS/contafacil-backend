using contafacil.back.Application.Interfaces;
using System;

namespace contafacil.back.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}