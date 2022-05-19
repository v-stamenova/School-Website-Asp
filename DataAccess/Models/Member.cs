namespace DataAccess.Models
{
	public class Member : BaseEntity
	{
		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public bool IsInSchoolBoard { get; set; }

		public Role Role { get; set; }
		public int RoleId { get; set; }
	}
}
