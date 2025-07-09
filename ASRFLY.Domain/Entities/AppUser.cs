namespace ASRFLY.Domain.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; }
        // Other properties can be added as needed
    }
}
