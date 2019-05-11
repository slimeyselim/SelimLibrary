namespace SelimLibrary.Data.Entities
{
    public interface IMember
    {
        string Email { get; set; }
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string Username { get; set; }
    }
}