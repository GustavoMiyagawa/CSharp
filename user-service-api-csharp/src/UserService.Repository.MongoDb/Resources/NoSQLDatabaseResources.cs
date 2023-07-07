namespace UserService.Repository.MongoDb.Resources;

public class NoSQLDatabaseResources
{
    public string Host { get; set; }
    public string Port { get; set; }
    public string Password { get; set; }
    public string User { get; set; }
    public string DatabaseName { get; set; }
    public string ConnectionString => $"mongodb://{User}:{Password}@{Host}:{Port}/?authSource={DatabaseName}";
}