using ExperimentWebApiNinject.Utilities.Interface;
using System;

namespace ExperimentWebApiNinject.Utilities
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime CurrentUtcTime()
        {
            return DateTime.UtcNow;
        }
    }
}