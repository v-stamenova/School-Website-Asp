using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Web.Services
{
	public class GraduateService
	{
		private SchoolDbContext _dbContext;

		public GraduateService(SchoolDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public Class GetClass(string year, char letter)
		{
			return this.GetClasses()
				.First(x => x.Letter == letter && x.Year == year);
		}

		public List<Class> GetClasses()
		{
			return this._dbContext.Classes.Include(x => x.Photos)
				.Include(x => x.HomeroomTeacher)
				.Include(x => x.Students)
				.ToList();
		}

		public List<Class> GetClassesOfYear(string year)
		{
			return this.GetClasses().Where(x => x.Year == year).ToList();
		}

		public List<Photo> PhotosOfClass(Class wantedClass)
		{
			return this._dbContext.Photos.Include(x => x.Class).Where(x => x.Class == wantedClass).ToList();
		}

		public List<Student> StudentsOfClass(Class wantedClass)
		{
			return this._dbContext.Students.Include(x => x.Class).Where(x => x.Class == wantedClass).ToList();
		}

		public void AddStudent(Student student)
		{
			this._dbContext.Students.Add(student);
			this._dbContext.SaveChanges();
		}
	}
}
