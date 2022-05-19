using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
	public class BaseEntity
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
	}
}
