using DataAccess.Models.Enums;
using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
	public class Article : BaseEntity
	{
		public Article()
		{
			this.AdditionalFiles = new List<AdditionalFile>();
		}

		public string Title { get; set; }

		public string Subtitle { get; set; }

		public string Content { get; set; }

		public string FilePath { get; set; }

		public DateTime CreatedOn { get; set; }

		public ArticleType Type { get; set; }
		public string TypeId { get; set; }

		public TargetGroup? Target { get; set; }
		
		public NormDocumentType? NormType { get; set; }

		public User PostedBy { get; set; }
		public string PostedById { get; set; }

		public List<AdditionalFile> AdditionalFiles { get; set; }
	}
}
