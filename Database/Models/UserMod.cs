namespace web_api.Database.Models;

public class UserMod
{
    public int Id { get; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }
}