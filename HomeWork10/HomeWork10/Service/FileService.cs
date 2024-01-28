namespace HomeWork10.Service
{
    using System;
    using System.IO;
    using HomeWork10.Models;
    using Newtonsoft.Json;

    public class FileService
    {
        public string LogDirectory;

        public string ProjectDirectory;

        public FileService(string logDirectory) 
        {
            LogDirectory = logDirectory;
            ProjectDirectory = @"F:\codingC#\ProjectsA-Level\HomeProjects\HomeWork10\HomeWork10\" + LogDirectory;
        }

        public void WriteToFile(Logger logContent)
        {
            CheckingExistenceLogDirective();

            string logFileName = $"{DateTime.Now:mm-dd-yyyy hh-mm-ss-fff}.json";

            string logFilePath = Path.Combine(ProjectDirectory, logFileName);

            File.WriteAllText(logFilePath, string.Join("\n", JsonConvert.SerializeObject(logContent.GetLogsArray())));

            CleanUpOldLog();
        }

        private void CheckingExistenceLogDirective()
        {

            if (!Directory.Exists(ProjectDirectory))
            {
                    Console.WriteLine($"Creating directory:{LogDirectory}");
                    Directory.CreateDirectory(ProjectDirectory);
            }
            else
            {
                Console.WriteLine($"The directory named {LogDirectory} already exists");
            }
        }

        private void CleanUpOldLog()
        {
            string[] logFiles = Directory.GetFiles(ProjectDirectory);

            Array.Sort(logFiles, (a, b) => new FileInfo(a).CreationTime.CompareTo(new FileInfo(b).CreationTime));
            int maxNumberFies = 3;
            int filesDelete = Math.Max(0, logFiles.Length - maxNumberFies);

            for (int i = 0; i < filesDelete; i++)
            {
                File.Delete(logFiles[i]);
            }
        }
    }
}
