namespace DataAccess.Models
{
	public class Student : BaseEntity
	{
		public string FirstName { get; set; }
		
		public char MiddleNameInitial { get; set; }

		public string FamilyName { get; set; }

		public Class Class { get; set; }
		public string Year { get; set; }
		public char Letter { get; set; }
	}
}
