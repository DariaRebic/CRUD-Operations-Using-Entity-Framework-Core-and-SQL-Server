namespace ASPNETMVCCRUD.Models
{
	public class UpdateEmployeeViewModel
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime DateOfBirth { get; set; }
		public String? Department { get; set; }
		public int Salary { get; set; }
	}
}
