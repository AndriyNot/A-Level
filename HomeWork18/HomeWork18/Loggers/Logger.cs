namespace HomeWork18.Loggers
{
    using System.Text.Json;
    using HomeWork18.Configs;

    public delegate void BackupEventHandler();

    public class Logger
    {
        public event BackupEventHandler BackupRequired;

        private List<string> _logEntries = new List<string>();
        private int backupThreshold;
        private readonly string _logFilePath;
        private readonly object _lockObject = new object();
        private int logCount = 0;

        public event EventHandler<string> LogBackup;

        public Logger(string logFilePath)
        {
            _logFilePath = logFilePath;

            LoadConfigAsync();
        }

        public async Task LogAsync(string message)
        {
            _logEntries.Add(message);
            logCount++;

            if (backupThreshold != 0 && logCount % backupThreshold == 0)
            {
                OnBackupRequired();

            }

            await WriteToFileAsync(message);
        }

        private async Task WriteToFileAsync(string message)
        {
            try
            {
                using (StreamWriter write = File.AppendText(_logFilePath))
                {
                    await write.WriteLineAsync(message).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");

            }
        }

        protected virtual void OnBackupRequired()
        {
            lock (_lockObject)
            {
                BackupEventHandler handler = BackupRequired;
                if (handler != null)
                {
                    handler.Invoke();
                }
            }
        }

        public async Task LoadConfigAsync()
        {
            try
            {
                string configFilePath = "config.json";
                if (File.Exists(configFilePath))
                {
                    string json = await File.ReadAllTextAsync(configFilePath).ConfigureAwait(false);
                    var config = JsonSerializer.Deserialize<Config>(json);

                    backupThreshold = config.BackupThreshold;
                }
                else
                {
                    var config = new Config { BackupThreshold = 10 };
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    var jsonString = JsonSerializer.Serialize(config, options);
                    await File.WriteAllTextAsync(configFilePath, jsonString).ConfigureAwait(false);

                    backupThreshold = config.BackupThreshold;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading configuration: {ex.Message}");
            }
        }

        public List<string> GetLogEntries()
        {
            return _logEntries;
        }
    }
}