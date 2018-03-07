namespace ConfigStoreDemo
{
    using System;

    public class Settings
    {
        public Settings()
        {
            string version = Environment.GetEnvironmentVariable("VERSION");
            string appName = Environment.GetEnvironmentVariable("APP_NAME");
            string refreshRate = Environment.GetEnvironmentVariable("REFRESH_RATE");
            string language = Environment.GetEnvironmentVariable("LANGUAGE");
            string messages = Environment.GetEnvironmentVariable("MESSAGES");

            if (!string.IsNullOrEmpty(version) && double.TryParse(version, out double numVersion))
            {
                this.Version = numVersion;
            }

            if (!string.IsNullOrEmpty(appName))
            {
                this.AppName = appName;
            }

            if (!string.IsNullOrEmpty(refreshRate) && long.TryParse(refreshRate, out long numRefreshRate))
            {
                this.RefreshRate = numRefreshRate;
            }
            
            if (!string.IsNullOrEmpty(language))
            {
                this.Language = language;
            }

            if (!string.IsNullOrEmpty(messages))
            {
                this.Messages = messages;
            }

            if (this.Version >= 2.0)
            {
                //
                // Refresh rate specified in seconds in version 2.0
                this.RefreshRate *= 1000;
            }
        }

        public double Version { get; set; } = 1.0;

        public string AppName { get; set; } = "ConfigStoreDemo";

        public long RefreshRate { get; set; } = 1000;

        public string Language { get; set; } = "English";

        public string Messages { get; set; } = "Hello There;Thanks For Using ConfigStoreDemo";
    }
}
