namespace DataAccess.Models
{
	public class AdditionalFile : BaseEntity
	{
		public string Heading { get; set; }

		public string Address { get; set; }

		public Article Article { get; set; }
		public int ArticleId { get; set; }
	}
}
