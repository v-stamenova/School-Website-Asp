using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
	public class CreateArticleViewModel
	{
		[Required(ErrorMessage = "Заглавието не може да е празно")]
		public string Title { get; set; }

		public string Subtitle { get; set; }

		public string Content { get; set; }

		public string FileUrl { get; set; }
		public IFormFile File { get; set; }
	}
}
