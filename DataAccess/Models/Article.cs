namespace DataAccess.Models
{
	public class Article : BaseEntity
	{
		public string Title { get; set; }

		public string Subtitle { get; set; }

		public string FilePath { get; set; }

		public User PostedBy { get; set; }
		public string PostedById { get; set; }
	}
}
