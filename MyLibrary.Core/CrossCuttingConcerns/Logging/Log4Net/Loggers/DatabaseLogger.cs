using log4net;

namespace MyLibrary.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class DatabaseLogger : LoggerService
    {
        public DatabaseLogger(ILog log) : base(LogManager.GetLogger("DatabaseLogger"))
        {
        }
    }
}
