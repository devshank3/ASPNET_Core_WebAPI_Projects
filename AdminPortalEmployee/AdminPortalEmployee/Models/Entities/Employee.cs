namespace AdminPortalEmployee.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public string? Department { get; set; }
        public required string Phone { get; set; }

    }
}
