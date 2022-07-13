using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
	public class Student : BaseEntity
	{
		public string FirstName { get; set; }
		
		public string FamilyName { get; set; }

		public Class Class { get; set; }
		public string Year { get; set; }

		[Column(TypeName = "int")]
		public char Letter { get; set; }
	}
}
