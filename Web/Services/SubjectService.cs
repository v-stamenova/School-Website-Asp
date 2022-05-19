using DataAccess;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace Web.Services
{
	public class SubjectService
	{
		private SchoolDbContext _dbContext;

		public SubjectService(SchoolDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public List<Subject> GetSubjects() => this._dbContext.Subjects.ToList();
	}
}
