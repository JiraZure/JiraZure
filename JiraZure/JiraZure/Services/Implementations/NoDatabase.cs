using JiraZure.Models.CustomExceptions;
using JiraZure.Services.Interfaces;

namespace JiraZure.Services.Implementations
{
    // only for testing purposes and Database will be created if i know what i need 
    public class NoDatabase : IServerConfiguration
    {
        public NoDatabase()
        {
        }

        public ServerConfiguration GetServerConfiguration()
        {
           var testingConf = new ServerConfiguration
           {
               AzureServers = new[] { "https://srv/DefaultCollection/" },
               AzurePat = "3oph2sgkls5zwqhyjzzy4vct3elnlbm3sm7qol7jzdj6cpybv4sa",
               AzureProject = "JiraZure_Azure",
               JiraServers = new[] { "https://azurewithjira.atlassian.net/jira/" },
               JiraPat = GetJiraPat(),
               JiraProject = "JiraZure_Jira",
               ContainerName = "debugoO  :D",
               Standalone = true
           };
            return testingConf;

           
        }
        private string GetJiraPat()
        {
            string environmentVariableValue = Environment.GetEnvironmentVariable("JiraPat") ?? "";

            if (string.IsNullOrEmpty(environmentVariableValue))
            {
                throw new EnviromentException("JiraPat");
            }

            return environmentVariableValue;
        }
    }
}
