using log4net;

namespace MyLibrary.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class FileLogger : LoggerService
    {
        public FileLogger(ILog log) : base(LogManager.GetLogger("JsonFileLogger"))
        {
        }
    }
}
