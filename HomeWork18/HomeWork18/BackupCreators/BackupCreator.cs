namespace HomeWork18.BackupCreators
{
    using System;
    using System.Collections.Generic;

    public class BackupCreator
    {
        public static void CreateBackup(List<string> logEntries, int batchSize)
        {
            string backupFolderPath = "Backup";
            string backupFileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}_part{logEntries.Count / batchSize + 1}.txt";
            string backupFilePath = Path.Combine(backupFolderPath, backupFileName);

            if (!Directory.Exists(backupFolderPath))
            {
                Directory.CreateDirectory(backupFolderPath);
            }

            int startIndex = Math.Max(0, logEntries.Count - batchSize);
            List<string> entriesToBackup = logEntries.GetRange(startIndex, Math.Min(batchSize, logEntries.Count - startIndex));

            File.WriteAllLines(backupFilePath, entriesToBackup);
        }
    }
}
