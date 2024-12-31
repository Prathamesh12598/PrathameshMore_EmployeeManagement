
namespace UniqueEmployeeManagement.Models
{
    public class EmployeeRecord
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "Default Name";
        public string Email { get; set; } = "@gmail.com";
        public string Department { get; set; } = "General";
        public string Position { get; set; } = "Employee";
        public decimal Salary { get; set; } = 30000.00M;
    }
}
