using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Web.Services
{
	public class TeacherService
	{
		private SchoolDbContext _dbContext;

		public TeacherService(SchoolDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public List<Teacher> GetTeachers() => this._dbContext.Teachers.Include(x => x.Subject).ToList();

		public List<Teacher> GetLeadingTeam() => this.GetTeachers().Where(x => x.AdditionalRole is not null).Where(x => x.AdditionalRole.ToLower().Contains("директор")).ToList();

		public List<Teacher> GetHeadTeachers() => this.GetTeachers().Where(x => x.IsHeadTeacher).ToList();

		public Teacher GetTeacher(string id) => this.GetTeachers().First(x => x.Username == id);
	}
}
