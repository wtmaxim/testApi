namespace testApi.Models
{
    public class Role
    {
        public Guid Id { get; set; }

        public string RoleName { get; set; }

        public User User { get; set; }

        public Guid UserId { get; set; }
    }

}
