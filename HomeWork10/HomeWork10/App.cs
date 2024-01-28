namespace HomeWork10
{
    using System;
    using HomeWork10.Models;
    using HomeWork10.Service;

    public class App
        {
            private  Actions actions;

            private  FileService fileService;

            private  Logger logger;

            public App(Actions actions, Logger logger, FileService fileService)
            {
                this.actions = actions;
                this.logger = logger;
                this.fileService = fileService;
            }

            public void Run()
            {
                Random random = new Random();

                for (int i = 0; i < 100; i++)
                {
                    int randomAction = random.Next(1, 4);

                    try
                    {
                        switch (randomAction)
                        {
                            case 1:
                                actions.StartMethod();
                                break;
                            case 2:
                                actions.SkipLogic();
                                break;
                            case 3:
                                actions.BreakLogic();
                                break;
                        }
                    }
                    catch (BusinessException ex)
                    {
                        logger.LogToFile(LoggerType.Warning, $"Action got this custom Exception:{ex.Message}");

                    }
                    catch (Exception ex)
                    {
                        logger.LogToFile(LoggerType.Error, $"Action failed by reason:{ex.Message}");
                    }
                }

                fileService.WriteToFile(logger);
            }
        }
}
