using System.Collections.Generic;

namespace DataAccess.Models
{
	public class Subject
	{
		public Subject()
		{
			this.Teachers = new List<Teacher>();
		}

		public string Id { get; set; } 

		public string FullName { get; set; }

		public string ColorHex { get; set; }

		public ICollection<Teacher> Teachers { get; set; }
	}
}
