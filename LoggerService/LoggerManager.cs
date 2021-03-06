using Entities.Contracts;

using NLog;

namespace LoggerService
{
    /// <summary>
    /// LoggerManager class for logging messages to log file
    /// </summary>
    public class LoggerManager : ILoggerManager
    {
        static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// LogDebug method
        /// </summary>
        /// <param name="message"></param>
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        /// <summary>
        /// LogError method
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message)
        {
            logger.Error(message);
        }

        /// <summary>
        /// LogInfo method
        /// </summary>
        /// <param name="message"></param>
        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        /// <summary>
        /// LogWarn method
        /// </summary>
        /// <param name="message"></param>
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}
