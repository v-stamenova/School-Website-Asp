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
	}
}
