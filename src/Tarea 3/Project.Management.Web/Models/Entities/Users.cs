namespace Project.Management.Web.Models.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public bool Active { get; set; }
    }
}
