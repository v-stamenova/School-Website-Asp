using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
	public class Photo : BaseEntity
	{
		public string Address { get; set; }

		public Class Class { get; set; }
		public string ClassYear { get; set; }

		[Column(TypeName = "int")]
		public char ClassLetter { get; set; }
	}
}
