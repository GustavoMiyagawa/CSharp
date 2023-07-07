namespace UserService.Shared.Helpers;

public abstract class EnvironmentHelper
{
    public static string GetStringEnvironmentValue(string environment)
    {
        return Environment.GetEnvironmentVariable(environment)
               ?? throw new NullReferenceException($"Environment '{environment}' not found");
    }
}