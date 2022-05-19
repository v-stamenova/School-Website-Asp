using DataAccess;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace Web.Services
{
	public class EmployeeService
	{
		private SchoolDbContext _dbContext;

		public EmployeeService(SchoolDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public List<Employee> GetEmployees() => this._dbContext.Employees.ToList();

		public List<Employee> GetAdministration() => this.GetEmployees().Where(x => !x.JobDescription.ToLower().Contains("психолог")).ToList();

		public Employee GetPsychologist() => this.GetEmployees().First(x => x.JobDescription.ToLower().Contains("психолог"));
	}
}
