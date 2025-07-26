namespace MyAsp.netWebAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }

        // 🔐 Required for authentication
        public string Email { get; set; }

        public string Password { get; set; }  // Later: store hashed passwords
    }
}
