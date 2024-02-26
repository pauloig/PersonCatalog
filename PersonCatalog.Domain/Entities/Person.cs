// Domain/Entities/Person.cs
namespace Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string? DNI { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
    }
}
