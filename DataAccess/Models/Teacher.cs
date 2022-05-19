using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
	public class Teacher
	{
		[Key]
		public string Username { get; set; }

		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		public string LastName { get; set; }

		public string Biography { get; set; }

		public DateTime Birthdate { get; set; }

		public string Email { get; set; }

		public bool IsHeadTeacher { get; set; }

		public string AdditionalRole { get; set; }

		public Subject Subject { get; set; }
		public string SubjectId { get; set; }
	}
}
