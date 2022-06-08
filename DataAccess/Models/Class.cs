﻿using System.Collections.Generic;

namespace DataAccess.Models
{
	public class Class
	{
		public Class()
		{
			this.Students = new List<Student>();
			this.Photos = new List<Photo>();
		}

		public string Year { get; set; }
		public char Letter { get; set; }

		public Teacher HomeroomTeacher { get; set; }
		public string HomeroomTeacherId { get; set; }

		public List<Student> Students { get; set; }

		public List<Photo> Photos { get; set; }
	}
}