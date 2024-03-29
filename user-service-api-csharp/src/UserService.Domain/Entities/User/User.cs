namespace UserService.Domain.Entities.User;

public class User
{
    public string Id = Guid.NewGuid().ToString();
    public string Username { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}