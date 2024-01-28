namespace HomeWork10.Models
{
    using System;

    public class Actions
    {
        private Logger logger;

        public Actions(Logger logger)
        {
            this.logger = logger;
        }

        public void StartMethod()
        {
            logger.LogToFile(LoggerType.Info, "Start method");
        }

        public void SkipLogic()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public void BreakLogic()
        {
            throw new Exception("I broke a logic");
        }
    }
}
