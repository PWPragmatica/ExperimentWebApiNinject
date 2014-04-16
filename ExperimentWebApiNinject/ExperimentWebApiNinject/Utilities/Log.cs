using ExperimentWebApiNinject.Utilities.Interface;
using System.Diagnostics;

namespace ExperimentWebApiNinject.Utilities
{
    public class Log : ILog
    {
        public void Write(string message)
        {
            Debug.WriteLine(message);
        }
    }
}