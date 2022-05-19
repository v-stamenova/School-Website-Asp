using System.Collections.Generic;

namespace DataAccess.Models
{
	public class Role : BaseEntity
	{
		public Role()
		{
			this.Members = new List<Member>();
		}

		public string Name { get; set; }

		public ICollection<Member> Members { get; set; }
	}
}
