public record ServerConfiguration
{
    public string[] AzureServers { get; init; }

    public string AzurePat { get; init; }

    public string AzureProject { get; init; }

    public string[] JiraServers { get; init; }
    
    public string JiraPat { get; init; }
    public string JiraProject { get; init; }
    public string ContainerName { get; init; }
    public bool Standalone { get; init; }
}